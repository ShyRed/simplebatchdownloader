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
            this.buttonExportUrlsTxt = new System.Windows.Forms.Button();
            this.checkBoxOnlyOne = new System.Windows.Forms.CheckBox();
            this.labelFilterByExtension = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.buttonDeselectAll = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.labelDownloadFolder = new System.Windows.Forms.Label();
            this.buttonBrowseTargetFolder = new System.Windows.Forms.Button();
            this.textBoxTargetFolder = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxUrlOrFile = new System.Windows.Forms.TextBox();
            this.labelWebsiteUrls = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxExtractZipFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxOverwrite = new System.Windows.Forms.CheckBox();
            this.buttonAbortDownload = new System.Windows.Forms.Button();
            this.progressBarProgress = new System.Windows.Forms.ProgressBar();
            this.listViewDownloadItems = new System.Windows.Forms.ListView();
            this.columnHeaderFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialogUrls = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUrlCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSelectionCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelGitHub = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDownloadParameters = new System.Windows.Forms.TabPage();
            this.tabPageProxy = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProxyUrl = new System.Windows.Forms.TextBox();
            this.checkBoxUseProxy = new System.Windows.Forms.CheckBox();
            this.tabPageFileRenaming = new System.Windows.Forms.TabPage();
            this.checkBoxRemoveLeadingNumbersAndSymbols = new System.Windows.Forms.CheckBox();
            this.saveFileDialogUrlsTxt = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageDownloadParameters.SuspendLayout();
            this.tabPageProxy.SuspendLayout();
            this.tabPageFileRenaming.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExportUrlsTxt);
            this.panel1.Controls.Add(this.checkBoxOnlyOne);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 98);
            this.panel1.TabIndex = 0;
            // 
            // buttonExportUrlsTxt
            // 
            this.buttonExportUrlsTxt.Enabled = false;
            this.buttonExportUrlsTxt.Location = new System.Drawing.Point(619, 70);
            this.buttonExportUrlsTxt.Name = "buttonExportUrlsTxt";
            this.buttonExportUrlsTxt.Size = new System.Drawing.Size(116, 23);
            this.buttonExportUrlsTxt.TabIndex = 13;
            this.buttonExportUrlsTxt.Text = "Export Urls.txt...";
            this.buttonExportUrlsTxt.UseVisualStyleBackColor = true;
            this.buttonExportUrlsTxt.Click += new System.EventHandler(this.buttonExportUrlsTxt_Click);
            // 
            // checkBoxOnlyOne
            // 
            this.checkBoxOnlyOne.AutoSize = true;
            this.checkBoxOnlyOne.Location = new System.Drawing.Point(383, 73);
            this.checkBoxOnlyOne.Name = "checkBoxOnlyOne";
            this.checkBoxOnlyOne.Size = new System.Drawing.Size(187, 19);
            this.checkBoxOnlyOne.TabIndex = 12;
            this.checkBoxOnlyOne.Text = "Select only one file per group";
            this.checkBoxOnlyOne.UseVisualStyleBackColor = true;
            // 
            // labelFilterByExtension
            // 
            this.labelFilterByExtension.AutoSize = true;
            this.labelFilterByExtension.Location = new System.Drawing.Point(12, 74);
            this.labelFilterByExtension.Name = "labelFilterByExtension";
            this.labelFilterByExtension.Size = new System.Drawing.Size(73, 15);
            this.labelFilterByExtension.TabIndex = 11;
            this.labelFilterByExtension.Text = "Regex Filter";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(115, 71);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilter.TabIndex = 10;
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
            // labelDownloadFolder
            // 
            this.labelDownloadFolder.AutoSize = true;
            this.labelDownloadFolder.Location = new System.Drawing.Point(12, 46);
            this.labelDownloadFolder.Name = "labelDownloadFolder";
            this.labelDownloadFolder.Size = new System.Drawing.Size(101, 15);
            this.labelDownloadFolder.TabIndex = 7;
            this.labelDownloadFolder.Text = "Download Folder";
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
            // textBoxTargetFolder
            // 
            this.textBoxTargetFolder.Location = new System.Drawing.Point(115, 43);
            this.textBoxTargetFolder.Name = "textBoxTargetFolder";
            this.textBoxTargetFolder.Size = new System.Drawing.Size(498, 20);
            this.textBoxTargetFolder.TabIndex = 5;
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
            this.labelWebsiteUrls.Size = new System.Drawing.Size(95, 15);
            this.labelWebsiteUrls.TabIndex = 0;
            this.labelWebsiteUrls.Text = "Website / urls.txt";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDownload);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonAbortDownload);
            this.panel2.Controls.Add(this.progressBarProgress);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 69);
            this.panel2.TabIndex = 1;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDownload.Enabled = false;
            this.buttonDownload.Location = new System.Drawing.Point(153, 23);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(555, 46);
            this.buttonDownload.TabIndex = 0;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBoxExtractZipFiles);
            this.panel3.Controls.Add(this.checkBoxOverwrite);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 46);
            this.panel3.TabIndex = 4;
            // 
            // checkBoxExtractZipFiles
            // 
            this.checkBoxExtractZipFiles.AutoSize = true;
            this.checkBoxExtractZipFiles.Location = new System.Drawing.Point(12, 26);
            this.checkBoxExtractZipFiles.Name = "checkBoxExtractZipFiles";
            this.checkBoxExtractZipFiles.Size = new System.Drawing.Size(112, 19);
            this.checkBoxExtractZipFiles.TabIndex = 3;
            this.checkBoxExtractZipFiles.Text = "Extract ZIP files";
            this.checkBoxExtractZipFiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxOverwrite
            // 
            this.checkBoxOverwrite.AutoSize = true;
            this.checkBoxOverwrite.Location = new System.Drawing.Point(12, 6);
            this.checkBoxOverwrite.Name = "checkBoxOverwrite";
            this.checkBoxOverwrite.Size = new System.Drawing.Size(150, 19);
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
            this.listViewDownloadItems.HideSelection = false;
            this.listViewDownloadItems.Location = new System.Drawing.Point(0, 130);
            this.listViewDownloadItems.Name = "listViewDownloadItems";
            this.listViewDownloadItems.Size = new System.Drawing.Size(805, 221);
            this.listViewDownloadItems.TabIndex = 2;
            this.listViewDownloadItems.UseCompatibleStateImageBehavior = false;
            this.listViewDownloadItems.View = System.Windows.Forms.View.Details;
            this.listViewDownloadItems.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewDownloadItems_ItemChecked);
            this.listViewDownloadItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEventMonitor);
            // 
            // columnHeaderFile
            // 
            this.columnHeaderFile.Text = "File";
            this.columnHeaderFile.Width = 200;
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
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Size";
            // 
            // openFileDialogUrls
            // 
            this.openFileDialogUrls.DefaultExt = "txt";
            this.openFileDialogUrls.Filter = "Text files|*.txt|All files|*.*";
            this.openFileDialogUrls.Title = "Open Urls.txt";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUrlCount,
            this.toolStripStatusLabelSelectionCount,
            this.toolStripStatusLabelGitHub});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(805, 30);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUrlCount
            // 
            this.toolStripStatusLabelUrlCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelUrlCount.Name = "toolStripStatusLabelUrlCount";
            this.toolStripStatusLabelUrlCount.Size = new System.Drawing.Size(113, 24);
            this.toolStripStatusLabelUrlCount.Text = "No Urls loaded";
            // 
            // toolStripStatusLabelSelectionCount
            // 
            this.toolStripStatusLabelSelectionCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelSelectionCount.Name = "toolStripStatusLabelSelectionCount";
            this.toolStripStatusLabelSelectionCount.Size = new System.Drawing.Size(121, 24);
            this.toolStripStatusLabelSelectionCount.Text = "No Urls selected";
            // 
            // toolStripStatusLabelGitHub
            // 
            this.toolStripStatusLabelGitHub.IsLink = true;
            this.toolStripStatusLabelGitHub.Name = "toolStripStatusLabelGitHub";
            this.toolStripStatusLabelGitHub.Size = new System.Drawing.Size(556, 24);
            this.toolStripStatusLabelGitHub.Spring = true;
            this.toolStripStatusLabelGitHub.Text = "Visit GitHub";
            this.toolStripStatusLabelGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelGitHub.Click += new System.EventHandler(this.toolStripStatusLabelGitHub_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDownloadParameters);
            this.tabControl1.Controls.Add(this.tabPageProxy);
            this.tabControl1.Controls.Add(this.tabPageFileRenaming);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 130);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageDownloadParameters
            // 
            this.tabPageDownloadParameters.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageDownloadParameters.Controls.Add(this.panel1);
            this.tabPageDownloadParameters.Location = new System.Drawing.Point(4, 22);
            this.tabPageDownloadParameters.Name = "tabPageDownloadParameters";
            this.tabPageDownloadParameters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDownloadParameters.Size = new System.Drawing.Size(797, 104);
            this.tabPageDownloadParameters.TabIndex = 0;
            this.tabPageDownloadParameters.Text = "Download Parameters";
            // 
            // tabPageProxy
            // 
            this.tabPageProxy.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageProxy.Controls.Add(this.label3);
            this.tabPageProxy.Controls.Add(this.textBoxPassword);
            this.tabPageProxy.Controls.Add(this.label2);
            this.tabPageProxy.Controls.Add(this.textBoxUsername);
            this.tabPageProxy.Controls.Add(this.label1);
            this.tabPageProxy.Controls.Add(this.textBoxProxyUrl);
            this.tabPageProxy.Controls.Add(this.checkBoxUseProxy);
            this.tabPageProxy.Location = new System.Drawing.Point(4, 22);
            this.tabPageProxy.Name = "tabPageProxy";
            this.tabPageProxy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProxy.Size = new System.Drawing.Size(797, 104);
            this.tabPageProxy.TabIndex = 1;
            this.tabPageProxy.Text = "Proxy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Location = new System.Drawing.Point(198, 66);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(160, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Enabled = false;
            this.textBoxUsername.Location = new System.Drawing.Point(198, 40);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(160, 20);
            this.textBoxUsername.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proxy IP and Port";
            // 
            // textBoxProxyUrl
            // 
            this.textBoxProxyUrl.Enabled = false;
            this.textBoxProxyUrl.Location = new System.Drawing.Point(198, 14);
            this.textBoxProxyUrl.Name = "textBoxProxyUrl";
            this.textBoxProxyUrl.Size = new System.Drawing.Size(160, 20);
            this.textBoxProxyUrl.TabIndex = 1;
            this.textBoxProxyUrl.Text = "localhost:8080";
            // 
            // checkBoxUseProxy
            // 
            this.checkBoxUseProxy.AutoSize = true;
            this.checkBoxUseProxy.Location = new System.Drawing.Point(8, 16);
            this.checkBoxUseProxy.Name = "checkBoxUseProxy";
            this.checkBoxUseProxy.Size = new System.Drawing.Size(84, 19);
            this.checkBoxUseProxy.TabIndex = 0;
            this.checkBoxUseProxy.Text = "Use Proxy";
            this.checkBoxUseProxy.UseVisualStyleBackColor = true;
            this.checkBoxUseProxy.CheckedChanged += new System.EventHandler(this.checkBoxUseProxy_CheckedChanged);
            // 
            // tabPageFileRenaming
            // 
            this.tabPageFileRenaming.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageFileRenaming.Controls.Add(this.checkBoxRemoveLeadingNumbersAndSymbols);
            this.tabPageFileRenaming.Location = new System.Drawing.Point(4, 22);
            this.tabPageFileRenaming.Name = "tabPageFileRenaming";
            this.tabPageFileRenaming.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFileRenaming.Size = new System.Drawing.Size(797, 104);
            this.tabPageFileRenaming.TabIndex = 2;
            this.tabPageFileRenaming.Text = "File renaming";
            // 
            // checkBoxRemoveLeadingNumbersAndSymbols
            // 
            this.checkBoxRemoveLeadingNumbersAndSymbols.AutoSize = true;
            this.checkBoxRemoveLeadingNumbersAndSymbols.Location = new System.Drawing.Point(8, 16);
            this.checkBoxRemoveLeadingNumbersAndSymbols.Name = "checkBoxRemoveLeadingNumbersAndSymbols";
            this.checkBoxRemoveLeadingNumbersAndSymbols.Size = new System.Drawing.Size(243, 19);
            this.checkBoxRemoveLeadingNumbersAndSymbols.TabIndex = 0;
            this.checkBoxRemoveLeadingNumbersAndSymbols.Text = "Remove leading numbers and symbols";
            this.checkBoxRemoveLeadingNumbersAndSymbols.UseVisualStyleBackColor = true;
            this.checkBoxRemoveLeadingNumbersAndSymbols.CheckedChanged += new System.EventHandler(this.fileRenameOption_CheckedChanged);
            // 
            // saveFileDialogUrlsTxt
            // 
            this.saveFileDialogUrlsTxt.DefaultExt = "txt";
            this.saveFileDialogUrlsTxt.Filter = "Text files|*.txt|All files|*.*";
            this.saveFileDialogUrlsTxt.Title = "Export Urls.txt";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.listViewDownloadItems);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(764, 489);
            this.Name = "Main";
            this.Text = "Simple Batch Downloader";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEventMonitor);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageDownloadParameters.ResumeLayout(false);
            this.tabPageProxy.ResumeLayout(false);
            this.tabPageProxy.PerformLayout();
            this.tabPageFileRenaming.ResumeLayout(false);
            this.tabPageFileRenaming.PerformLayout();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBoxExtractZipFiles;
        private System.Windows.Forms.CheckBox checkBoxOnlyOne;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDownloadParameters;
        private System.Windows.Forms.TabPage tabPageProxy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProxyUrl;
        private System.Windows.Forms.CheckBox checkBoxUseProxy;
        private System.Windows.Forms.Button buttonExportUrlsTxt;
        private System.Windows.Forms.SaveFileDialog saveFileDialogUrlsTxt;
        private System.Windows.Forms.TabPage tabPageFileRenaming;
        private System.Windows.Forms.CheckBox checkBoxRemoveLeadingNumbersAndSymbols;
    }
}

