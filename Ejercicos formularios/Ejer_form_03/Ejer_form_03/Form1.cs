using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejer_form_03
{
    public partial class Form1 : Form
    {
        bool Play = false;
        string[] MP3files;
        string[] MP3routes;
        public Form1()
        {
            InitializeComponent();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileBrowser = new OpenFileDialog();
            FileBrowser.Multiselect = true;
            if (FileBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MP3files = FileBrowser.SafeFileNames;
                MP3routes = FileBrowser.FileNames;
                foreach (var MP3file in MP3files)
                {
                    sList.Items.Add(MP3file);
                }
                rep.URL = MP3routes[0];
                sList.SelectedIndex = 0;
                PlayBtn.Image = Properties.Resources.pause;
            }
        }

        private void sList_SelectedIndexChanged(object sender, EventArgs e)
        {
            rep.URL = MP3routes[sList.SelectedIndex];
            sName.Text = MP3files[sList.SelectedIndex];
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            switch (Play)
            {
                case true:
                    rep.Ctlcontrols.pause();
                    PlayBtn.Image = Properties.Resources.play;
                    Play = false;
                    break;
                case false:
                    rep.Ctlcontrols.play();
                    PlayBtn.Image = Properties.Resources.pause;
                    Play = true;
                    break;
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            rep.Ctlcontrols.stop();
            PlayBtn.Image= Properties.Resources.play;
            Play = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            upadteTrackerData();
            sStatus.Value = (int)rep.Ctlcontrols.currentPosition;
            vController.Value = rep.settings.volume;
        }
        public void upadteTrackerData()
        {
            if (rep.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                sStatus.Maximum = (int)rep.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (rep.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (rep.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                sStatus.Value = 0;
            }
        }

        private void rep_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            upadteTrackerData();
        }
    }
}
