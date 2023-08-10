using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (FileBrowser.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                MP3files = FileBrowser.SafeFileNames;
                MP3routes = FileBrowser.FileNames;
                foreach (var MP3file in MP3files)
                {
                    sList.Items.Add(MP3file);
                }
                rep.URL = MP3routes[0];
                sList.SelectedIndex = 0;
            }
        }

        private void sList_SelectedIndexChanged(object sender, EventArgs e)
        {
            rep.URL = MP3routes[sList.SelectedIndex];
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            switch(Play)
            {
                case true:
                    rep.Ctlcontrols.pause();
                    PlayBtn.Image = Properties.Resources.play_button;
                    Play = false;
                    break; 
                case false:
                    rep.Ctlcontrols.pause();
                    PlayBtn.Image = Properties.Resources.pause;
                    Play = true;
                    break;
            }
        }
    }
}
