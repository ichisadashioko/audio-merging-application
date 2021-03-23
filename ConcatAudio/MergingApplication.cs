using System;
using System.Windows.Forms;
using System.IO;

namespace ConcatAudio
{
    public partial class MergingApplication : Form
    {
        bool IsLoadingSettings { get; set; }

        public MergingApplication()
        {
            InitializeComponent();
            IsLoadingSettings = true;

            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.TargetDirectory))
            {
                targetLocationTB.Text = Properties.Settings.Default.TargetDirectory;
            }

            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.TargetFileName))
            {
                targetFileNameTB.Text = Properties.Settings.Default.TargetFileName;
            }

            if (Properties.Settings.Default.ExportFormat.Equals("mp3", StringComparison.InvariantCultureIgnoreCase))
            {
                mp3FormatRadioButton.Checked = true;
            }
            else
            {
                wavFormatRadioButton.Checked = true;
            }

            IsLoadingSettings = false;
        }

        private void UpdateSettings(object sender, EventArgs e)
        {
            if (IsLoadingSettings)
            {
                return;
            }

            if (!targetLocationTB.Text.Equals(Properties.Settings.Default.TargetDirectory))
            {
                Properties.Settings.Default.TargetDirectory = targetLocationTB.Text;
            }

            if (!targetFileNameTB.Text.Equals(Properties.Settings.Default.TargetFileName))
            {
                Properties.Settings.Default.TargetFileName = targetFileNameTB.Text;
            }

            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Filter = "Audio files(*.MP3;*.WAV)|*.MP3,;*.WAV";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var filePath in openFileDialog.FileNames)
                    {
                        var filePathObj = new AudioFileEntries() { FilePath = filePath };
                        audioFileEntriesListBox.Items.Add(filePathObj);
                    }
                }
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startCancelButton_Click(object sender, EventArgs e)
        {
            // TODO check for target format

            // If they are all the same with the input files, continue.

            // If they are not, convert them to the target format
        }
    }

    public class AudioFileEntries
    {
        public string FilePath { get; set; }
        public override string ToString()
        {
            return this.FilePath.Substring(this.FilePath.LastIndexOf('\\') + 1);
        }
    }
}
