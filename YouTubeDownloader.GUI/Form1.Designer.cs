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
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.Dock = DockStyle.Fill;
            MainSplitContainer.Location = new Point(10, 10);
            MainSplitContainer.MinimumSize = new Size(300, 300);
            MainSplitContainer.Name = "MainSplitContainer";
            MainSplitContainer.Panel1MinSize = 100;
            MainSplitContainer.Panel2MinSize = 100;
            MainSplitContainer.Size = new Size(780, 430);
            MainSplitContainer.SplitterDistance = 390;
            MainSplitContainer.SplitterWidth = 1;
            MainSplitContainer.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer MainSplitContainer;
    }
}
