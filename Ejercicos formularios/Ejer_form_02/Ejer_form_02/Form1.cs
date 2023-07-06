using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            DialogResult dialog;
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Todos los archivos|*|archivos JPG|*.jpg|archivos PNG|*.png|archivos GIF|*.gif";
            dialog = openFileDialog1.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
          
            
        }
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

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
