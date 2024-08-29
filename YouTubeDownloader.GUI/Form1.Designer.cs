namespace YouTubeDownloader.GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainSplitContainer = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            outputFormatPanel = new Panel();
            radioButtonMp3 = new RadioButton();
            radioButtonMp4 = new RadioButton();
            label4 = new Label();
            panel1 = new Panel();
            urlTextBox = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            selectFolderButton = new Button();
            selectedFolderTextBox = new TextBox();
            videoQualityPanel = new Panel();
            radioButtonHighestAvailable = new RadioButton();
            label2 = new Label();
            radioButton2160p = new RadioButton();
            radioButton1440p = new RadioButton();
            radioButton1080p = new RadioButton();
            radioButton720p = new RadioButton();
            radioButton240p = new RadioButton();
            radioButton360p = new RadioButton();
            radioButton144p = new RadioButton();
            radioButton480p = new RadioButton();
            button1 = new Button();
            audioQualityPanel = new Panel();
            radioButtonHighest = new RadioButton();
            radioButtonLowest = new RadioButton();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            mainTitleLabel = new Label();
            videoInfoPanel = new Panel();
            videoSizeLabel = new Label();
            videoLengthLabel = new Label();
            downloadedQualityLabel = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            outputFormatPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            videoQualityPanel.SuspendLayout();
            audioQualityPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            videoInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.Dock = DockStyle.Fill;
            MainSplitContainer.FixedPanel = FixedPanel.Panel1;
            MainSplitContainer.IsSplitterFixed = true;
            MainSplitContainer.Location = new Point(10, 10);
            MainSplitContainer.MinimumSize = new Size(300, 300);
            MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.Controls.Add(tableLayoutPanel1);
            MainSplitContainer.Panel1MinSize = 370;
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.Controls.Add(tableLayoutPanel2);
            MainSplitContainer.Panel2MinSize = 300;
            MainSplitContainer.Size = new Size(780, 430);
            MainSplitContainer.SplitterDistance = 370;
            MainSplitContainer.SplitterWidth = 1;
            MainSplitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(outputFormatPanel, 0, 4);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(videoQualityPanel, 0, 2);
            tableLayoutPanel1.Controls.Add(button1, 0, 5);
            tableLayoutPanel1.Controls.Add(audioQualityPanel, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(320, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.71941F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.7431145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.9288864F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999894F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999894F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6088F));
            tableLayoutPanel1.Size = new Size(370, 430);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // outputFormatPanel
            // 
            outputFormatPanel.Controls.Add(radioButtonMp3);
            outputFormatPanel.Controls.Add(radioButtonMp4);
            outputFormatPanel.Controls.Add(label4);
            outputFormatPanel.Dock = DockStyle.Fill;
            outputFormatPanel.Location = new Point(3, 306);
            outputFormatPanel.Name = "outputFormatPanel";
            outputFormatPanel.Size = new Size(364, 36);
            outputFormatPanel.TabIndex = 5;
            // 
            // radioButtonMp3
            // 
            radioButtonMp3.AutoSize = true;
            radioButtonMp3.Location = new Point(214, 8);
            radioButtonMp3.Name = "radioButtonMp3";
            radioButtonMp3.Size = new Size(49, 19);
            radioButtonMp3.TabIndex = 11;
            radioButtonMp3.Text = "mp3";
            radioButtonMp3.UseVisualStyleBackColor = true;
            // 
            // radioButtonMp4
            // 
            radioButtonMp4.AutoSize = true;
            radioButtonMp4.Checked = true;
            radioButtonMp4.Location = new Point(159, 8);
            radioButtonMp4.Name = "radioButtonMp4";
            radioButtonMp4.Size = new Size(49, 19);
            radioButtonMp4.TabIndex = 10;
            radioButtonMp4.TabStop = true;
            radioButtonMp4.Text = "mp4";
            radioButtonMp4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 10);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 10;
            label4.Text = "Select Output Format:";
            // 
            // panel1
            // 
            panel1.Controls.Add(urlTextBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 95);
            panel1.TabIndex = 0;
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(30, 50);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.PlaceholderText = "Paste the URL or ID here...";
            urlTextBox.Size = new Size(321, 23);
            urlTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(244, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter the YouTube video or playlist URL or ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(selectFolderButton);
            panel2.Controls.Add(selectedFolderTextBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(364, 65);
            panel2.TabIndex = 1;
            // 
            // selectFolderButton
            // 
            selectFolderButton.Location = new Point(108, 32);
            selectFolderButton.Name = "selectFolderButton";
            selectFolderButton.Size = new Size(157, 23);
            selectFolderButton.TabIndex = 3;
            selectFolderButton.Text = "Select Download Folder";
            selectFolderButton.UseVisualStyleBackColor = true;
            selectFolderButton.Click += selectFolderButton_Click;
            // 
            // selectedFolderTextBox
            // 
            selectedFolderTextBox.Location = new Point(30, 3);
            selectedFolderTextBox.Name = "selectedFolderTextBox";
            selectedFolderTextBox.PlaceholderText = "No folder selected";
            selectedFolderTextBox.Size = new Size(321, 23);
            selectedFolderTextBox.TabIndex = 2;
            // 
            // videoQualityPanel
            // 
            videoQualityPanel.Controls.Add(radioButtonHighestAvailable);
            videoQualityPanel.Controls.Add(label2);
            videoQualityPanel.Controls.Add(radioButton2160p);
            videoQualityPanel.Controls.Add(radioButton1440p);
            videoQualityPanel.Controls.Add(radioButton1080p);
            videoQualityPanel.Controls.Add(radioButton720p);
            videoQualityPanel.Controls.Add(radioButton240p);
            videoQualityPanel.Controls.Add(radioButton360p);
            videoQualityPanel.Controls.Add(radioButton144p);
            videoQualityPanel.Controls.Add(radioButton480p);
            videoQualityPanel.Dock = DockStyle.Fill;
            videoQualityPanel.Location = new Point(3, 175);
            videoQualityPanel.Name = "videoQualityPanel";
            videoQualityPanel.Size = new Size(364, 83);
            videoQualityPanel.TabIndex = 2;
            // 
            // radioButtonHighestAvailable
            // 
            radioButtonHighestAvailable.AutoSize = true;
            radioButtonHighestAvailable.Checked = true;
            radioButtonHighestAvailable.Location = new Point(198, 51);
            radioButtonHighestAvailable.Name = "radioButtonHighestAvailable";
            radioButtonHighestAvailable.Size = new Size(115, 19);
            radioButtonHighestAvailable.TabIndex = 9;
            radioButtonHighestAvailable.TabStop = true;
            radioButtonHighestAvailable.Text = "highest-available";
            radioButtonHighestAvailable.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 6);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 8;
            label2.Text = "Select Video Quality:";
            // 
            // radioButton2160p
            // 
            radioButton2160p.AutoSize = true;
            radioButton2160p.Location = new Point(142, 51);
            radioButton2160p.Name = "radioButton2160p";
            radioButton2160p.Size = new Size(56, 19);
            radioButton2160p.TabIndex = 7;
            radioButton2160p.Text = "2160p";
            radioButton2160p.UseVisualStyleBackColor = true;
            // 
            // radioButton1440p
            // 
            radioButton1440p.AutoSize = true;
            radioButton1440p.Location = new Point(86, 51);
            radioButton1440p.Name = "radioButton1440p";
            radioButton1440p.Size = new Size(56, 19);
            radioButton1440p.TabIndex = 6;
            radioButton1440p.Text = "1440p";
            radioButton1440p.UseVisualStyleBackColor = true;
            // 
            // radioButton1080p
            // 
            radioButton1080p.AutoSize = true;
            radioButton1080p.Location = new Point(30, 51);
            radioButton1080p.Name = "radioButton1080p";
            radioButton1080p.Size = new Size(56, 19);
            radioButton1080p.TabIndex = 5;
            radioButton1080p.Text = "1080p";
            radioButton1080p.UseVisualStyleBackColor = true;
            // 
            // radioButton720p
            // 
            radioButton720p.AutoSize = true;
            radioButton720p.Location = new Point(254, 26);
            radioButton720p.Name = "radioButton720p";
            radioButton720p.Size = new Size(50, 19);
            radioButton720p.TabIndex = 4;
            radioButton720p.Text = "720p";
            radioButton720p.UseVisualStyleBackColor = true;
            // 
            // radioButton240p
            // 
            radioButton240p.AutoSize = true;
            radioButton240p.Location = new Point(86, 26);
            radioButton240p.Name = "radioButton240p";
            radioButton240p.Size = new Size(50, 19);
            radioButton240p.TabIndex = 3;
            radioButton240p.Text = "240p";
            radioButton240p.UseVisualStyleBackColor = true;
            // 
            // radioButton360p
            // 
            radioButton360p.AutoSize = true;
            radioButton360p.Location = new Point(142, 26);
            radioButton360p.Name = "radioButton360p";
            radioButton360p.Size = new Size(50, 19);
            radioButton360p.TabIndex = 2;
            radioButton360p.Text = "360p";
            radioButton360p.UseVisualStyleBackColor = true;
            // 
            // radioButton144p
            // 
            radioButton144p.AutoSize = true;
            radioButton144p.Location = new Point(30, 26);
            radioButton144p.Name = "radioButton144p";
            radioButton144p.Size = new Size(50, 19);
            radioButton144p.TabIndex = 1;
            radioButton144p.Text = "144p";
            radioButton144p.UseVisualStyleBackColor = true;
            // 
            // radioButton480p
            // 
            radioButton480p.AutoSize = true;
            radioButton480p.Location = new Point(198, 26);
            radioButton480p.Name = "radioButton480p";
            radioButton480p.Size = new Size(50, 19);
            radioButton480p.TabIndex = 0;
            radioButton480p.Text = "480p";
            radioButton480p.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(122, 370);
            button1.Name = "button1";
            button1.Size = new Size(126, 34);
            button1.TabIndex = 3;
            button1.Text = "Begin Download";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // audioQualityPanel
            // 
            audioQualityPanel.Controls.Add(radioButtonHighest);
            audioQualityPanel.Controls.Add(radioButtonLowest);
            audioQualityPanel.Controls.Add(label3);
            audioQualityPanel.Dock = DockStyle.Fill;
            audioQualityPanel.Location = new Point(3, 264);
            audioQualityPanel.Name = "audioQualityPanel";
            audioQualityPanel.Size = new Size(364, 36);
            audioQualityPanel.TabIndex = 4;
            // 
            // radioButtonHighest
            // 
            radioButtonHighest.AutoSize = true;
            radioButtonHighest.Checked = true;
            radioButtonHighest.Location = new Point(215, 8);
            radioButtonHighest.Name = "radioButtonHighest";
            radioButtonHighest.Size = new Size(64, 19);
            radioButtonHighest.TabIndex = 11;
            radioButtonHighest.TabStop = true;
            radioButtonHighest.Text = "highest";
            radioButtonHighest.UseVisualStyleBackColor = true;
            // 
            // radioButtonLowest
            // 
            radioButtonLowest.AutoSize = true;
            radioButtonLowest.Location = new Point(148, 8);
            radioButtonLowest.Name = "radioButtonLowest";
            radioButtonLowest.Size = new Size(59, 19);
            radioButtonLowest.TabIndex = 10;
            radioButtonLowest.Text = "lowest";
            radioButtonLowest.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 10);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 10;
            label3.Text = "Select Audio Quality:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(mainTitleLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(videoInfoPanel, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(409, 430);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // mainTitleLabel
            // 
            mainTitleLabel.AutoSize = true;
            mainTitleLabel.Dock = DockStyle.Fill;
            mainTitleLabel.Font = new Font("Segoe UI", 11F);
            mainTitleLabel.Location = new Point(3, 25);
            mainTitleLabel.Margin = new Padding(3, 25, 3, 25);
            mainTitleLabel.Name = "mainTitleLabel";
            mainTitleLabel.Size = new Size(403, 20);
            mainTitleLabel.TabIndex = 1;
            mainTitleLabel.Text = "No video or playlist selected.";
            // 
            // videoInfoPanel
            // 
            videoInfoPanel.AutoSize = true;
            videoInfoPanel.Controls.Add(videoSizeLabel);
            videoInfoPanel.Controls.Add(videoLengthLabel);
            videoInfoPanel.Controls.Add(downloadedQualityLabel);
            videoInfoPanel.Dock = DockStyle.Fill;
            videoInfoPanel.Location = new Point(3, 73);
            videoInfoPanel.Name = "videoInfoPanel";
            videoInfoPanel.Padding = new Padding(15);
            videoInfoPanel.Size = new Size(403, 354);
            videoInfoPanel.TabIndex = 2;
            // 
            // videoSizeLabel
            // 
            videoSizeLabel.AutoSize = true;
            videoSizeLabel.Font = new Font("Segoe UI", 10F);
            videoSizeLabel.Location = new Point(18, 46);
            videoSizeLabel.Name = "videoSizeLabel";
            videoSizeLabel.Size = new Size(0, 19);
            videoSizeLabel.TabIndex = 2;
            // 
            // videoLengthLabel
            // 
            videoLengthLabel.AutoSize = true;
            videoLengthLabel.Font = new Font("Segoe UI", 10F);
            videoLengthLabel.Location = new Point(18, 15);
            videoLengthLabel.Name = "videoLengthLabel";
            videoLengthLabel.Size = new Size(0, 19);
            videoLengthLabel.TabIndex = 1;
            // 
            // downloadedQualityLabel
            // 
            downloadedQualityLabel.AutoSize = true;
            downloadedQualityLabel.Font = new Font("Segoe UI", 10F);
            downloadedQualityLabel.Location = new Point(18, 77);
            downloadedQualityLabel.Name = "downloadedQualityLabel";
            downloadedQualityLabel.Size = new Size(0, 19);
            downloadedQualityLabel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainSplitContainer);
            MinimumSize = new Size(700, 300);
            Name = "Form1";
            Padding = new Padding(10);
            Text = "Youtube Downloader";
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            outputFormatPanel.ResumeLayout(false);
            outputFormatPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            videoQualityPanel.ResumeLayout(false);
            videoQualityPanel.PerformLayout();
            audioQualityPanel.ResumeLayout(false);
            audioQualityPanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            videoInfoPanel.ResumeLayout(false);
            videoInfoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer MainSplitContainer;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox urlTextBox;
        private Label label1;
        private Panel panel2;
        private TextBox selectedFolderTextBox;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button selectFolderButton;
        private Panel videoQualityPanel;
        private RadioButton radioButton720p;
        private RadioButton radioButton240p;
        private RadioButton radioButton360p;
        private RadioButton radioButton144p;
        private RadioButton radioButton480p;
        private RadioButton radioButton2160p;
        private RadioButton radioButton1440p;
        private RadioButton radioButton1080p;
        private Label label2;
        private RadioButton radioButtonHighestAvailable;
        private Button button1;
        private Panel audioQualityPanel;
        private RadioButton radioButtonHighest;
        private RadioButton radioButtonLowest;
        private Label label3;
        private Panel outputFormatPanel;
        private RadioButton radioButtonMp3;
        private RadioButton radioButtonMp4;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private Label mainTitleLabel;
        private Panel videoInfoPanel;
        private Label downloadedQualityLabel;
        private Label videoLengthLabel;
        private Label videoSizeLabel;
    }
}
