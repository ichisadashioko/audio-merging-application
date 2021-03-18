using System;
using System.Windows.Forms;
using System.IO;

namespace ConcatAudio
{
    public partial class MergingApplication : Form
    {
        public MergingApplication()
        {
            InitializeComponent();
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
