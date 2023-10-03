using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MediaPlayerEr
{
    public partial class Form1 : Form
    {
        List<string> path = new List<string>();
        private bool isMuted = false;

        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
            timer1.Enabled = true;
            Playlist.ScrollAlwaysVisible = true;
            Playlist.HorizontalScrollbar = true;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = " Video MP4 | *.mp4| MP3 Audio File | *.mp3";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path.Add(openFileDialog1.FileName);           
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 10;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = " Video MP4 | *.mp4| MP3 Audio File | *.mp3|" + " Windows Media File | *.wma |WAV Audio File | *.wav";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    path.Add(openFileDialog1.FileNames[i]);
                    Playlist.Items.Add(Path.GetFileNameWithoutExtension(openFileDialog1.FileNames[i]));
                }
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }         
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 Audio File (*.mp3)|*.mp3";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path.Add(openFileDialog1.FileName);
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void playlistToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (panel6.Visible == true)
            {
                panel6.Hide();
                playlistToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
            else
            {
                panel6.Show();
                playlistToolStripMenuItem.CheckState = CheckState.Checked;
            }
        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton14_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton17_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuImageButton16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 10;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            if (Playlist.SelectedIndex < Playlist.Items.Count + 1)
            {
                Playlist.SelectedIndex = Playlist.SelectedIndex - 1;
            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (isMuted)
            {
                axWindowsMediaPlayer1.settings.mute = false; // Unmute
                bunifuImageButton11.Text = "Mute";
            }
            else
            {
                axWindowsMediaPlayer1.settings.mute = true; // Mute
                bunifuImageButton11.Text = "Unmute";
            }

            isMuted = !isMuted;
           
        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            if (Playlist.SelectedIndex < Playlist.Items.Count - 1)
            {
                Playlist.SelectedIndex = Playlist.SelectedIndex + 1;
            }
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {           
            axWindowsMediaPlayer1.settings.volume = bunifuHSlider1.Value; 
            label2.Text = bunifuHSlider1.Value.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuHSlider2_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = bunifuHSlider2.Value;
        }

        private void bunifuHSlider3_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int currentMediaPosition = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            bunifuHSlider2.Value = currentMediaPosition;
            label3.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
        }


        private void StartMediaPlayback()
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            timer1.Start();
        }
        private void StopMediaPlayback()
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            timer1.Stop();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Playlist_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = path[Playlist.SelectedIndex];
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
        }
    }
}
