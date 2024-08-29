using YouTubeDownloader.Core;
using static YouTubeDownloader.Core.DownloadOptions;

namespace YouTubeDownloader.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFolderTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string videoUrl = urlTextBox.Text;
            if (string.IsNullOrEmpty(videoUrl))
            {
                MessageBox.Show("Please enter a URL.");
                return;
            }
            if (string.IsNullOrEmpty(selectedFolderTextBox.Text))
            {
                MessageBox.Show("Please select a folder to save the videos.");
                return;
            }
            var (isPlaylist, normalizedUrl) = ProcessYouTubeInput(videoUrl);

            if (!isPlaylist)
            {
                DownloadOptions downloadOptions = new()
                {
                    Url = normalizedUrl,
                    VideoQuality = "highest-available",
                    AudioQuality = "highest-available",
                    Format = "mp4",
                    OutputDirectory = selectedFolderTextBox.Text,
                    IsPlaylist = false
                };
                VideoDownloader videoDownloader = new();
                var (data, errorMessage) = await videoDownloader.TryGetVideoMetadata(downloadOptions);
                if (errorMessage != null)
                {
                    MessageBox.Show(errorMessage);
                    return;
                }
                var videoMetadata = data!;
                mainTitleLabel.Text = $"Video Title: {videoMetadata.Title}";
                var (success, message) = await videoDownloader.DownloadVideoAsync(downloadOptions);
                if (success)
                {
                    MessageBox.Show("Download completed.");
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
        }
    }
}