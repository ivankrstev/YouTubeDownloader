using System.Diagnostics;
using System.Drawing;
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
            beginDownloadButton.Enabled = false;
            beginDownloadButton.Text = "Downloading...";
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
                videoInfoPanel.Visible = true;
                playlistInfoPanel.Visible = false;
                CleanUpInfoLabels();
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
            else
            {
                CleanUpPlaylistInfoLabels();
                videoInfoPanel.Visible = false;
                playlistInfoPanel.Visible = true;
                DownloadOptions downloadOptions = new()
                {
                    Url = normalizedUrl,
                    VideoQuality = GetSelectedRadioButton(videoQualityPanel),
                    AudioQuality = GetSelectedRadioButton(audioQualityPanel),
                    Format = GetSelectedRadioButton(outputFormatPanel),
                    OutputDirectory = selectedFolderTextBox.Text,
                    IsPlaylist = true
                };
                PlaylistDownloader playlistDownloader = new(downloadOptions);
                var (playlistMetadata, videosMetadata) = await playlistDownloader.GetPlaylistMetadataAndVideos(normalizedUrl);
                mainTitleLabel.Text = $"Selected playlist: {playlistMetadata.Title}";
                videosCountLabel.Text = $"{videosMetadata.Count} videos found.";
                // Add the videos to the list view
                foreach (var video in videosMetadata)
                {
                    ListViewItem item = new(video.Title); // Create a new item with the video title
                    item.SubItems.Add(video.Duration.ToString()); // Add the video duration to the item
                    item.SubItems.Add(""); // Empty for now, will update after download
                    item.SubItems.Add(""); // Empty for now, will update after download
                    item.SubItems.Add(""); // Empty for now, will update after download
                    listView1.Items.Add(item); // Add the item to the list view
                }
                // Start downloading the videos
                foreach (var video in videosMetadata)
                {
                    downloadOptions.Url = video.Url;
                    VideoDownloader videoDownloader = new();
                    var videoDownloadResponse = await videoDownloader.DownloadVideoAsync(downloadOptions);
                    if (videoDownloadResponse.Size != null && videoDownloadResponse.VideoAudioQuality != null)
                    {
                        foreach (ListViewItem item in listView1.Items)
                        {
                            if (item.Text == video.Title)
                            {
                                item.SubItems[2].Text = videoDownloadResponse.Size; // Update the video size
                                string[] splittedQualities = videoDownloadResponse.VideoAudioQuality.Split("|");
                                item.SubItems[3].Text = splittedQualities[0].Replace("Quality(video):", ""); // Update the video quality
                                item.SubItems[4].Text = splittedQualities[1].Replace("Bitrate(audio):", ""); // Update the audio quality
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(videoDownloadResponse.Message);
                    }
                }
            }
            beginDownloadButton.Enabled = true;
            beginDownloadButton.Text = "Begin Download";
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

        private void CleanUpInfoLabels()
        {
            foreach (var control in videoInfoPanel.Controls)
            {
                if (control is Label label)
                {
                    label.Text = "";
                }
            }
        }

        private void CleanUpPlaylistInfoLabels()
        {
            foreach (var control in playlistInfoPanel.Controls)
            {
                if (control is Label label)
                {
                    label.Text = "";
                }
            }
            // also clear the data grid view
            listView1.Items.Clear();
        }
    }
}