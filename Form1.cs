using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace zalfamediaplayer
{
    public partial class Form1 : Form
    {
        List<string> path = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click_2(object sender, EventArgs e)
        {

        }

        private void bunifuPanel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click_3(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = " Video MP4 | *.mp4| MP3 Audio File | *.mp3|" + " Windows Media File | *.wma |WAV Audio File | *.wav";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    path.Add(openFileDialog1.FileNames[i]);
                    listBox1.Items.Add(Path.GetFileNameWithoutExtension(openFileDialog1.FileNames[i]));
                }
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaFile file = listBox1.SelectedItem as MediaFile;
            if (file != null)
            {
                axWindowsMediaPlayer1.URL = file.Path;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }


        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = path[listBox1.SelectedIndex];
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
