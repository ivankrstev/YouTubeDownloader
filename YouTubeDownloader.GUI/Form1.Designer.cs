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
            folderBrowserDialog1 = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
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
            panel1.Size = new Size(384, 101);
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
            panel2.Location = new Point(3, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 101);
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
    }
}
