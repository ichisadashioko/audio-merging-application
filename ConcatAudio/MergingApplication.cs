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
            int size = 1;
            var fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileToOpen = fileDialog.FileName;
                audioFileEntriesListBox.Items.Add(fileToOpen);

                //FileInfo selectedFile = new FileInfo(fileToOpen);
            }
        }
    }
}
