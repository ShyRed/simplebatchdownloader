using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBatchDownloader
{
    public partial class Main : Form
    {
        private static readonly Regex LinkRegex = new Regex("href=\"(.*?)\"", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private bool _Downloading = false;

        public Main()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            textBoxTargetFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folderBrowserDialogTarget.SelectedPath = textBoxTargetFolder.Text;
        }

        private async void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUrlOrFile.Text) || !textBoxUrlOrFile.Text.StartsWith("http", StringComparison.OrdinalIgnoreCase))
            {
                if (openFileDialogUrls.ShowDialog() != DialogResult.OK)
                    return;

                string filename = openFileDialogUrls.FileName;
                textBoxUrlOrFile.Text = filename;
            }

            buttonBrowse.Enabled = false;
            listViewDownloadItems.ItemChecked -= listViewDownloadItems_ItemChecked;
            await FetchUrlsFromFileOrWebsite();
            listViewDownloadItems.ItemChecked += listViewDownloadItems_ItemChecked;
            buttonBrowse.Enabled = true;

            toolStripStatusLabelUrlCount.Text = $"{listViewDownloadItems.Items.Count} Urls loaded";
            toolStripStatusLabelSelectionCount.Text = $"{listViewDownloadItems.CheckedItems.Count} Urls selected";
        }

        private void buttonBrowseTargetFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogTarget.ShowDialog() != DialogResult.OK)
                return;

            textBoxTargetFolder.Text = folderBrowserDialogTarget.SelectedPath;
        }

        private async Task FetchUrlsFromFileOrWebsite()
        {
            var path = textBoxUrlOrFile.Text;
            var urls = new List<string>();

            try
            {
                if (path.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                {
                    using(var client = new HttpClient())
                    {
                        var result = await client.GetAsync(path);
                        if (!result.IsSuccessStatusCode)
                            throw new InvalidOperationException($"[{result.StatusCode}] {result.ReasonPhrase}");

                        var html = await result.Content.ReadAsStringAsync();
                        urls.AddRange(LinkRegex.Matches(html).Cast<Match>().Select(match => match.Groups[1].Value).Where(url => !url.EndsWith("/")));
                    }
                }
                else
                {
                    using (var fs = new StreamReader(path))
                    {
                        var line = await fs.ReadLineAsync();
                        while (!string.IsNullOrWhiteSpace(line))
                        {
                            urls.Add(line);
                            line = await fs.ReadLineAsync();
                        }
                    }
                }

                var filter = new Regex(textBoxFilter.Text, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                listViewDownloadItems.SuspendLayout();

                listViewDownloadItems.Items.Clear();
                listViewDownloadItems.Items.AddRange(urls.OrderBy(url => url).Select(url => new ListViewItem(new[] {
                    MakeFilename(url),
                    MakeFullUrl(path, url),
                    string.Empty,
                    string.Empty
                })
                { Checked = filter.IsMatch(url) }).ToArray());

                if (checkBoxOnlyOne.Checked)
                    SelectOnlyOneFilePerGroup();

                listViewDownloadItems.ResumeLayout();

                progressBarProgress.Value = 0;

                buttonDownload.Enabled = listViewDownloadItems.Items.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open \"{path}\": {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            var filter = new Regex(textBoxFilter.Text, RegexOptions.Singleline | RegexOptions.IgnoreCase);

            listViewDownloadItems.ItemChecked -= listViewDownloadItems_ItemChecked;

            foreach (ListViewItem item in listViewDownloadItems.Items)
                item.Checked = filter.IsMatch(item.SubItems[0].Text);

            if (checkBoxOnlyOne.Checked)
                SelectOnlyOneFilePerGroup();

            listViewDownloadItems.ItemChecked += listViewDownloadItems_ItemChecked;

            toolStripStatusLabelSelectionCount.Text = $"{listViewDownloadItems.CheckedItems.Count} Urls selected";
        }

        private void buttonDeselectAll_Click(object sender, EventArgs e)
        {
            listViewDownloadItems.ItemChecked -= listViewDownloadItems_ItemChecked;
            foreach (ListViewItem item in listViewDownloadItems.Items)
                item.Checked = false;
            listViewDownloadItems.ItemChecked += listViewDownloadItems_ItemChecked;
            toolStripStatusLabelSelectionCount.Text = $"{listViewDownloadItems.CheckedItems.Count} Urls selected";
        }

        private void listViewDownloadItems_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            toolStripStatusLabelSelectionCount.Text = $"{listViewDownloadItems.CheckedItems.Count} Urls selected";
        }

        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            SetDownloading(true);

            var progress = 0;
            progressBarProgress.Maximum = listViewDownloadItems.Items.Count;
            foreach (ListViewItem item in listViewDownloadItems.Items)
            {
                if (!_Downloading)
                    break;

                if (!item.Checked)
                {
                    item.SubItems[2].Text = "Skipped";
                    progress++;
                    progressBarProgress.Value = progress;
                    continue;
                }

                var filename = Path.Combine(textBoxTargetFolder.Text, item.SubItems[0].Text);
                if (File.Exists(filename) && !checkBoxOverwrite.Checked)
                {
                    item.SubItems[2].Text = "Already exists";
                }
                else
                {
                    item.SubItems[2].Text = "Loading...";
                    item.SubItems[2].Text = await Download(item.SubItems[1].Text, filename);
                    await Task.Delay(100 + (int)(rnd.NextDouble() * 500)); // Don't flood server with requests...
                }

                if (File.Exists(filename) && filename.EndsWith(".zip", StringComparison.OrdinalIgnoreCase) && checkBoxExtractZipFiles.Checked)
                {
                    item.SubItems[2].Text = "Extracting...";
                    item.SubItems[2].Text = await ExtractZipFile(filename);
                }

                progress++;
                progressBarProgress.Value = progress;
            }
            SetDownloading(false);
        }

        private void buttonAbortDownload_Click(object sender, EventArgs e)
        {
            buttonAbortDownload.Enabled = false;
            _Downloading = false;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            var url = ((Uri)((TaskCompletionSource<object>)e.UserState).Task.AsyncState).AbsoluteUri;
            var item = listViewDownloadItems.Items.Cast<ListViewItem>().FirstOrDefault(x => x.SubItems[1].Text == url);
            if (item == null)
                return;

            item.SubItems[2].Text = $"{e.ProgressPercentage} %";

            if (item.SubItems[3].Text == string.Empty)
                item.SubItems[3].Text = MakeSize(e.TotalBytesToReceive);
        }

        private void SelectOnlyOneFilePerGroup()
        {
            var currentGroup = string.Empty;
            for (int i = 0; i < listViewDownloadItems.Items.Count; i++)
            {
                var item = listViewDownloadItems.Items[i];
                if (!item.Checked)
                    continue;

                var group = MakeGroup(item.SubItems[0].Text);
                if (group == currentGroup)
                    item.Checked = false;
                else
                    currentGroup = group;
            }
        }

        private string MakeGroup(string filename)
        {
            for (int i = 0; i < filename.Length; i++)
                if (!char.IsLetterOrDigit(filename[i]) && !char.IsWhiteSpace(filename[i]))
                    return i == 0 ? string.Empty : filename.Substring(0, i);
            return filename;
        }

        private async Task<string> Download(string url, string targetFile)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadProgressChanged += Client_DownloadProgressChanged;
                    await client.DownloadFileTaskAsync(url, targetFile);
                    client.DownloadProgressChanged -= Client_DownloadProgressChanged;
                    return "Downloaded";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        private Task<string> ExtractZipFile(string filename)
        {
            return Task.Run<string>(() =>
            {
                try
                {
                    var fileInfo = new FileInfo(filename);
                    System.IO.Compression.ZipFile.ExtractToDirectory(filename, fileInfo.DirectoryName);
                    return "Downloaded & Extracted";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            });
        }

        private void SetDownloading(bool downloading)
        {
            _Downloading = downloading;

            checkBoxOverwrite.Enabled = !downloading;
            buttonBrowse.Enabled = !downloading;
            buttonBrowseTargetFolder.Enabled = !downloading;

            textBoxUrlOrFile.Enabled = !downloading;
            textBoxTargetFolder.Enabled = !downloading;

            buttonDownload.Enabled = !downloading;
            buttonAbortDownload.Enabled = downloading;
        }

        private static string MakeFilename(string url)
        {
            int last = url.LastIndexOf('/');
            if (last >= 0)
                url = url.Substring(last + 1);
            url = WebUtility.UrlDecode(url);
            return url;
        }

        private static string MakeFullUrl(string baseUrl, string url)
        {
            if (url.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                return url;

            if (!baseUrl.EndsWith("/") && !url.StartsWith("/"))
                baseUrl += "/";

            return baseUrl + url;
        }

        private static string MakeSize(long bytes)
        {
            double size = bytes;

            if (size < 1024)
                return bytes +" Bytes";

            size /= 1024;
            if (size < 1024)
                return $"{size:0.0} KB";

            size /= 1024;
            if (size < 1024)
                return $"{size:0.0} MB";

            size /= 1024;
            return $"{size:0.0} GB";
        }

        private void toolStripStatusLabelGitHub_Click(object sender, EventArgs e)
        {
            using (var process = new System.Diagnostics.Process())
            {
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "https://github.com/ShyRed/simplebatchdownloader";
                process.Start();
            }
        }
    }
}
