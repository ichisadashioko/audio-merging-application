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

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    audioFileEntriesListBox.Items.Add(filePath);
                }
            }
        }
    }
}
