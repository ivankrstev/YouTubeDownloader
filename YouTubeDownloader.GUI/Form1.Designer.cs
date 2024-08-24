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
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            selectFolderButton = new Button();
            selectedFolderTextBox = new TextBox();
            panel3 = new Panel();
            radioButton9 = new RadioButton();
            label2 = new Label();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            panel4 = new Panel();
            radioButton11 = new RadioButton();
            radioButton10 = new RadioButton();
            label3 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.Dock = DockStyle.Fill;
            MainSplitContainer.Location = new Point(10, 10);
            MainSplitContainer.MinimumSize = new Size(300, 300);
            MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.Controls.Add(tableLayoutPanel1);
            MainSplitContainer.Panel1MinSize = 100;
            MainSplitContainer.Panel2MinSize = 100;
            MainSplitContainer.Size = new Size(780, 430);
            MainSplitContainer.SplitterDistance = 390;
            MainSplitContainer.SplitterWidth = 1;
            MainSplitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(button1, 0, 5);
            tableLayoutPanel1.Controls.Add(panel4, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.71941F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.7431145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.9288864F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999894F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999894F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6088F));
            tableLayoutPanel1.Size = new Size(390, 430);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 95);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 50);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Paste the URL or ID here...";
            textBox1.Size = new Size(321, 23);
            textBox1.TabIndex = 1;
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
            panel2.Size = new Size(384, 65);
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
            // panel3
            // 
            panel3.Controls.Add(radioButton9);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(radioButton8);
            panel3.Controls.Add(radioButton7);
            panel3.Controls.Add(radioButton6);
            panel3.Controls.Add(radioButton5);
            panel3.Controls.Add(radioButton4);
            panel3.Controls.Add(radioButton3);
            panel3.Controls.Add(radioButton2);
            panel3.Controls.Add(radioButton1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 175);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 83);
            panel3.TabIndex = 2;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Checked = true;
            radioButton9.Location = new Point(198, 51);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(115, 19);
            radioButton9.TabIndex = 9;
            radioButton9.TabStop = true;
            radioButton9.Text = "highest-available";
            radioButton9.UseVisualStyleBackColor = true;
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
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(142, 51);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(56, 19);
            radioButton8.TabIndex = 7;
            radioButton8.Text = "2160p";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(86, 51);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(56, 19);
            radioButton7.TabIndex = 6;
            radioButton7.Text = "1440p";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(30, 51);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(56, 19);
            radioButton6.TabIndex = 5;
            radioButton6.Text = "1080p";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(254, 26);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(50, 19);
            radioButton5.TabIndex = 4;
            radioButton5.Text = "720p";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(86, 26);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(50, 19);
            radioButton4.TabIndex = 3;
            radioButton4.Text = "240p";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(142, 26);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(50, 19);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "360p";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(30, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "144p";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(198, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(50, 19);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "480p";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(132, 370);
            button1.Name = "button1";
            button1.Size = new Size(126, 34);
            button1.TabIndex = 3;
            button1.Text = "Begin Download";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(radioButton11);
            panel4.Controls.Add(radioButton10);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 264);
            panel4.Name = "panel4";
            panel4.Size = new Size(384, 36);
            panel4.TabIndex = 4;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Checked = true;
            radioButton11.Location = new Point(215, 8);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(64, 19);
            radioButton11.TabIndex = 11;
            radioButton11.TabStop = true;
            radioButton11.Text = "highest";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(148, 8);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(59, 19);
            radioButton10.TabIndex = 10;
            radioButton10.Text = "lowest";
            radioButton10.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainSplitContainer);
            MinimumSize = new Size(600, 300);
            Name = "Form1";
            Padding = new Padding(10);
            Text = "Youtube Downloader";
            MainSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer MainSplitContainer;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel2;
        private TextBox selectedFolderTextBox;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button selectFolderButton;
        private Panel panel3;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private Label label2;
        private RadioButton radioButton9;
        private Button button1;
        private Panel panel4;
        private RadioButton radioButton11;
        private RadioButton radioButton10;
        private Label label3;
    }
}
