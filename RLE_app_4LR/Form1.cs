using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RLE_app_4LR
{
    public partial class Form1 : Form
    {
        Packer packer = new Packer();
        public Form1()
        {
            InitializeComponent();
        }

        private void sFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            openFileDialog.InitialDirectory = @"C:\"; // директория по умолчанию
            if (openFileDialog.FileName != "")
            {
                sourcePath.Text = openFileDialog.FileName;
                Packer.SourceFileName = openFileDialog.FileName;
            }
        }
        private void dFilePath_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            saveFileDialog.InitialDirectory = @"C:\"; // директория по умолчанию
            if (saveFileDialog.FileName != "")
            {
                destPath.Text = saveFileDialog.FileName;
                Packer.DestFileName = saveFileDialog.FileName;
            }
        }
        private void dFilePath_TextChanged(object sender, EventArgs e)
        {
            if (dFilePath.Text.Length > 0 && sFilePath.Text.Length > 0)
            {
                pack.Enabled = true;
                unpack.Enabled = true;
            }

        }
        private void sFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void unpack_Click(object sender, EventArgs e)
        {
            packer.notifiera += ((i) => levelUp(i));
            packer.UnPack();
        }

        private void pack_Click(object sender, EventArgs e)
        {
            packer.notifiera += ((i) => levelUp(i));
            packer.Pack();
        }
        private void levelUp(int i)
        {
            PB.Value = i;
            stop.Enabled = true;
            if (PB.Value == PB.Maximum) { stop.Enabled = false; }
            Application.DoEvents();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            packer.Stop();
            PB.Value = PB.Minimum;
            stop.Enabled = false;
            
        }
    }
}
