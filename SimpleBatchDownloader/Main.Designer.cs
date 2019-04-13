namespace SimpleBatchDownloader
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxUrlOrFile = new System.Windows.Forms.TextBox();
            this.labelWebsiteUrls = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.progressBarProgress = new System.Windows.Forms.ProgressBar();
            this.listViewDownloadItems = new System.Windows.Forms.ListView();
            this.columnHeaderFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialogUrls = new System.Windows.Forms.OpenFileDialog();
            this.textBoxTargetFolder = new System.Windows.Forms.TextBox();
            this.buttonBrowseTargetFolder = new System.Windows.Forms.Button();
            this.labelDownloadFolder = new System.Windows.Forms.Label();
            this.folderBrowserDialogTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.columnHeaderUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonDeselectAll = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.labelFilterByExtension = new System.Windows.Forms.Label();
            this.checkBoxOverwrite = new System.Windows.Forms.CheckBox();
            this.buttonAbortDownload = new System.Windows.Forms.Button();
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUrlCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSelectionCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelGitHub = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelFilterByExtension);
            this.panel1.Controls.Add(this.textBoxFilter);
            this.panel1.Controls.Add(this.buttonDeselectAll);
            this.panel1.Controls.Add(this.buttonSelectAll);
            this.panel1.Controls.Add(this.labelDownloadFolder);
            this.panel1.Controls.Add(this.buttonBrowseTargetFolder);
            this.panel1.Controls.Add(this.textBoxTargetFolder);
            this.panel1.Controls.Add(this.buttonBrowse);
            this.panel1.Controls.Add(this.textBoxUrlOrFile);
            this.panel1.Controls.Add(this.labelWebsiteUrls);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 102);
            this.panel1.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(619, 12);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(116, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse / Fetch...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxUrlOrFile
            // 
            this.textBoxUrlOrFile.Location = new System.Drawing.Point(115, 14);
            this.textBoxUrlOrFile.Name = "textBoxUrlOrFile";
            this.textBoxUrlOrFile.Size = new System.Drawing.Size(498, 20);
            this.textBoxUrlOrFile.TabIndex = 1;
            // 
            // labelWebsiteUrls
            // 
            this.labelWebsiteUrls.AutoSize = true;
            this.labelWebsiteUrls.Location = new System.Drawing.Point(12, 17);
            this.labelWebsiteUrls.Name = "labelWebsiteUrls";
            this.labelWebsiteUrls.Size = new System.Drawing.Size(87, 13);
            this.labelWebsiteUrls.TabIndex = 0;
            this.labelWebsiteUrls.Text = "Website / urls.txt";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDownload);
            this.panel2.Controls.Add(this.buttonAbortDownload);
            this.panel2.Controls.Add(this.checkBoxOverwrite);
            this.panel2.Controls.Add(this.progressBarProgress);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 69);
            this.panel2.TabIndex = 1;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDownload.Enabled = false;
            this.buttonDownload.Location = new System.Drawing.Point(142, 23);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(566, 46);
            this.buttonDownload.TabIndex = 0;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // progressBarProgress
            // 
            this.progressBarProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarProgress.Location = new System.Drawing.Point(0, 0);
            this.progressBarProgress.Name = "progressBarProgress";
            this.progressBarProgress.Size = new System.Drawing.Size(805, 23);
            this.progressBarProgress.TabIndex = 1;
            // 
            // listViewDownloadItems
            // 
            this.listViewDownloadItems.CheckBoxes = true;
            this.listViewDownloadItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFile,
            this.columnHeaderUrl,
            this.columnHeaderStatus,
            this.columnHeaderSize});
            this.listViewDownloadItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDownloadItems.GridLines = true;
            this.listViewDownloadItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewDownloadItems.Location = new System.Drawing.Point(0, 102);
            this.listViewDownloadItems.Name = "listViewDownloadItems";
            this.listViewDownloadItems.Size = new System.Drawing.Size(805, 255);
            this.listViewDownloadItems.TabIndex = 2;
            this.listViewDownloadItems.UseCompatibleStateImageBehavior = false;
            this.listViewDownloadItems.View = System.Windows.Forms.View.Details;
            this.listViewDownloadItems.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewDownloadItems_ItemChecked);
            // 
            // columnHeaderFile
            // 
            this.columnHeaderFile.Text = "File";
            this.columnHeaderFile.Width = 200;
            // 
            // openFileDialogUrls
            // 
            this.openFileDialogUrls.Filter = "Text files|*.txt|All files|*.*";
            // 
            // textBoxTargetFolder
            // 
            this.textBoxTargetFolder.Location = new System.Drawing.Point(115, 43);
            this.textBoxTargetFolder.Name = "textBoxTargetFolder";
            this.textBoxTargetFolder.Size = new System.Drawing.Size(498, 20);
            this.textBoxTargetFolder.TabIndex = 5;
            // 
            // buttonBrowseTargetFolder
            // 
            this.buttonBrowseTargetFolder.Location = new System.Drawing.Point(619, 41);
            this.buttonBrowseTargetFolder.Name = "buttonBrowseTargetFolder";
            this.buttonBrowseTargetFolder.Size = new System.Drawing.Size(116, 23);
            this.buttonBrowseTargetFolder.TabIndex = 6;
            this.buttonBrowseTargetFolder.Text = "Browse...";
            this.buttonBrowseTargetFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseTargetFolder.Click += new System.EventHandler(this.buttonBrowseTargetFolder_Click);
            // 
            // labelDownloadFolder
            // 
            this.labelDownloadFolder.AutoSize = true;
            this.labelDownloadFolder.Location = new System.Drawing.Point(12, 46);
            this.labelDownloadFolder.Name = "labelDownloadFolder";
            this.labelDownloadFolder.Size = new System.Drawing.Size(87, 13);
            this.labelDownloadFolder.TabIndex = 7;
            this.labelDownloadFolder.Text = "Download Folder";
            // 
            // columnHeaderUrl
            // 
            this.columnHeaderUrl.Text = "Url";
            this.columnHeaderUrl.Width = 400;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 140;
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(221, 69);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAll.TabIndex = 8;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonDeselectAll
            // 
            this.buttonDeselectAll.Location = new System.Drawing.Point(302, 69);
            this.buttonDeselectAll.Name = "buttonDeselectAll";
            this.buttonDeselectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonDeselectAll.TabIndex = 9;
            this.buttonDeselectAll.Text = "DeselectAll";
            this.buttonDeselectAll.UseVisualStyleBackColor = true;
            this.buttonDeselectAll.Click += new System.EventHandler(this.buttonDeselectAll_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(115, 71);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilter.TabIndex = 10;
            // 
            // labelFilterByExtension
            // 
            this.labelFilterByExtension.AutoSize = true;
            this.labelFilterByExtension.Location = new System.Drawing.Point(12, 74);
            this.labelFilterByExtension.Name = "labelFilterByExtension";
            this.labelFilterByExtension.Size = new System.Drawing.Size(92, 13);
            this.labelFilterByExtension.TabIndex = 11;
            this.labelFilterByExtension.Text = "Filter by Extension";
            // 
            // checkBoxOverwrite
            // 
            this.checkBoxOverwrite.AutoSize = true;
            this.checkBoxOverwrite.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBoxOverwrite.Location = new System.Drawing.Point(0, 23);
            this.checkBoxOverwrite.Name = "checkBoxOverwrite";
            this.checkBoxOverwrite.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.checkBoxOverwrite.Size = new System.Drawing.Size(142, 46);
            this.checkBoxOverwrite.TabIndex = 2;
            this.checkBoxOverwrite.Text = "Overwrite existing files";
            this.checkBoxOverwrite.UseVisualStyleBackColor = true;
            // 
            // buttonAbortDownload
            // 
            this.buttonAbortDownload.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAbortDownload.Enabled = false;
            this.buttonAbortDownload.Location = new System.Drawing.Point(708, 23);
            this.buttonAbortDownload.Name = "buttonAbortDownload";
            this.buttonAbortDownload.Size = new System.Drawing.Size(97, 46);
            this.buttonAbortDownload.TabIndex = 3;
            this.buttonAbortDownload.Text = "Abort";
            this.buttonAbortDownload.UseVisualStyleBackColor = true;
            this.buttonAbortDownload.Click += new System.EventHandler(this.buttonAbortDownload_Click);
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Size";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUrlCount,
            this.toolStripStatusLabelSelectionCount,
            this.toolStripStatusLabelGitHub});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(805, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUrlCount
            // 
            this.toolStripStatusLabelUrlCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelUrlCount.Name = "toolStripStatusLabelUrlCount";
            this.toolStripStatusLabelUrlCount.Size = new System.Drawing.Size(89, 19);
            this.toolStripStatusLabelUrlCount.Text = "No Urls loaded";
            // 
            // toolStripStatusLabelSelectionCount
            // 
            this.toolStripStatusLabelSelectionCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelSelectionCount.Name = "toolStripStatusLabelSelectionCount";
            this.toolStripStatusLabelSelectionCount.Size = new System.Drawing.Size(96, 19);
            this.toolStripStatusLabelSelectionCount.Text = "No Urls selected";
            // 
            // toolStripStatusLabelGitHub
            // 
            this.toolStripStatusLabelGitHub.IsLink = true;
            this.toolStripStatusLabelGitHub.Name = "toolStripStatusLabelGitHub";
            this.toolStripStatusLabelGitHub.Size = new System.Drawing.Size(574, 19);
            this.toolStripStatusLabelGitHub.Spring = true;
            this.toolStripStatusLabelGitHub.Text = "Visit GitHub";
            this.toolStripStatusLabelGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelGitHub.Click += new System.EventHandler(this.toolStripStatusLabelGitHub_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.listViewDownloadItems);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(764, 489);
            this.Name = "Main";
            this.Text = "Simple Batch Downloader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxUrlOrFile;
        private System.Windows.Forms.Label labelWebsiteUrls;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.ProgressBar progressBarProgress;
        private System.Windows.Forms.ListView listViewDownloadItems;
        private System.Windows.Forms.OpenFileDialog openFileDialogUrls;
        private System.Windows.Forms.ColumnHeader columnHeaderFile;
        private System.Windows.Forms.Label labelDownloadFolder;
        private System.Windows.Forms.Button buttonBrowseTargetFolder;
        private System.Windows.Forms.TextBox textBoxTargetFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogTarget;
        private System.Windows.Forms.ColumnHeader columnHeaderUrl;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.Label labelFilterByExtension;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonDeselectAll;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.CheckBox checkBoxOverwrite;
        private System.Windows.Forms.Button buttonAbortDownload;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUrlCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSelectionCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGitHub;
    }
}

