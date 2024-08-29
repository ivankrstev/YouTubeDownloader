using System.Windows.Forms;
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
                    VideoQuality = GetSelectedRadioButton(videoQualityPanel),
                    AudioQuality = GetSelectedRadioButton(audioQualityPanel),
                    Format = GetSelectedRadioButton(outputFormatPanel),
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
                mainTitleLabel.Text = $"Selected video: {videoMetadata.Title}";
                var videoDownloadResponse = await videoDownloader.DownloadVideoAsync(downloadOptions);
                if (videoDownloadResponse.Size != null && videoDownloadResponse.VideoAudioQuality != null)
                {
                    videoLengthLabel.Text = $"Video Length: {videoMetadata.Duration}";
                    videoSizeLabel.Text = $"Video Size: {videoDownloadResponse.Size}";
                    downloadedQualityLabel.Text = videoDownloadResponse.VideoAudioQuality;
                    MessageBox.Show("Download completed.");
                }
                else
                {
                    MessageBox.Show(videoDownloadResponse.Message);
                }
            }
        }

        private static string GetSelectedRadioButton(Panel panel)
        {
            foreach (var control in panel.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            if (panel.Name == "outputFormatPanel") return "mp4";
            return "highest-available";
        }
    }
}