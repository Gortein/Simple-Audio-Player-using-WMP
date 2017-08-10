using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public string songName;

        public Form1()
        {
            InitializeComponent();
            songVolSelect.Maximum = 100;
            songVolSelect.Minimum = 0;
            songVolSelect.Value = 50;
            songProgress.Minimum = 0;
            timer1.Interval = 1000;
        }

        private void songSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            //dlg.ShowDialog();
            dlg.Filter = "All Supported Audio | *.mp3; *.wma; *.m4a; *.wav";
            dlg.Multiselect = false;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                songName = fileName;
                MessageBox.Show(fileName);
                
            }
            player.URL = songName;
            player.controls.play();
            while (songName.Contains("\\"))
            {
                int i = songName.IndexOf('\\');
                if (i >= 0) songName = songName.Substring(i + 1);
            }
            if (songName.Contains("."))
            {
                int i = songName.IndexOf('.');
                if (i >= 0) songName = songName.Replace(songName.Substring(i), "");
            }
            songCurrent.Text = songName;
            songVolSelect.Update();
            timer1.Start();
        }
        private void songPause_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void songPlay_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void songVolSelect_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = songVolSelect.Value;
            songVolume.Text = "Volume: " + player.settings.volume.ToString() + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            songProgress.Maximum = Convert.ToInt32(player.currentMedia.duration);
            double t = Math.Floor(player.currentMedia.duration - player.controls.currentPosition);
            textBox1.Text = ("Seconds remaining: " + t.ToString());
            songProgress.Value = Convert.ToInt32((player.controls.currentPosition));
            songProgress.Update();
            if (songRepeat.Checked && (player.controls.currentPosition == 0))
            {
                player.controls.currentPosition = 0;
                player.controls.play();
            }
        }

        private void songProgress_Scroll(object sender, EventArgs e)
        {
            player.controls.currentPosition = songProgress.Value;
        }
    }
}
