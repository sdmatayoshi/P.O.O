using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer_form_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void itemSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itemCerrar_Click(object sender, EventArgs e)
        {

        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog()==DialogResult.OK)
            {
                org = new PictureBox();
                org.Load(od.FileName);
                pictureBox1.Load(od.FileName);
            }
            //DialogResult dialog;
            //openFileDialog1.Multiselect = true;
            //openFileDialog1.Filter = "Todos los archivos|*|archivos JPG|*.jpg|archivos PNG|*.png|archivos GIF|*.gif";
            //dialog = openFileDialog1.ShowDialog();
            //if (dialog == DialogResult.OK)
            //{
            //    try
            //    {
            //        pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            //    }
            //    catch (Exception exp)
            //    {
            //        MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}


        }
        Image ZoomPicture(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;


        }
        PictureBox org;
        private void Form1_Load(object sender, EventArgs e)
        {

            trackBar1.Minimum = 1;
            trackBar1.Maximum = 11;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.UseWaitCursor = false;
            this.DoubleBuffered = true;
            //org = new PictureBox();
            //org.Image = pictureBox1.Image;
        }
        //private void toolStripButton6_Click(Image img, Size size)
        //{
        //    int iw = img.Width;
        //    int sw = size.Width;
        //    int ih = img.Height;
        //    int sh = size.Height;
        //    Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
        //    Graphics gpu = Graphics.FromImage(bm);
        //    gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        //    pictureBox1.Image = bm;
        //}
        private void guardar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"JPG|*.jpg" })

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image.Save(saveFileDialog.FileName);
                    }
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Image = img;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = img;
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null)
            {
                toolStripButton1.Enabled = true;
                Clipboard.SetImage(pictureBox1.Image);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Clipboard.GetImage();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Clipboard.SetImage(pictureBox1.Image);
                pictureBox1.Image = null;
            }
        }

       

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value != 0)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = ZoomPicture(org.Image,new Size(trackBar1.Value,trackBar1.Value));
            }
        }
    }
}
