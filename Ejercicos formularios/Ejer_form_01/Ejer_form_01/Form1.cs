using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer_form_01
{
    public partial class Form1 : Form
    {
        int a;
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void Add1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
            }
            
        }
        private void Add2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                listBox2.Items.Add(textBox2.Text);
                textBox2.Clear();
                textBox2.Focus();
            }
        }


        private void All2to1_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.Items)
            {
                listBox1.Items.Add(item);
               
            }
            listBox2.Items.Clear();
        }

        private void Selected2to1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }
        private void All1to2_Click_1(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                listBox2.Items.Add(item);
            }
            listBox1.Items.Clear();
        }
        private void Selected1to2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox1.Text != "") {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox2.Text != "")
            {
                listBox2.Items.Add(textBox2.Text);
                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //1->3
            foreach (var item in listBox1.Items)
            {
                listBox3.Items.Add(item);
            }
            listBox1.Items.Clear();

            //2->4
            foreach (var item in listBox2.Items)
            {
                listBox4.Items.Add(item);
            }
            listBox2.Items.Clear();

            //3->2
            foreach (var item in listBox3.Items)
            {
                listBox2.Items.Add(item);
            }
            listBox3.Items.Clear();

            //4->1
            foreach (var item in listBox4.Items)
            {
                listBox1.Items.Add(item);
            }
            listBox4.Items.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null && listBox2.SelectedItem != null)
            {
                //1->3
                listBox3.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
                //2->4
                listBox4.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);

            }
            if (listBox3.Items.Count > 0 && listBox4.Items.Count > 0)
            {
                //3->2
                listBox3.SetSelected(0, true);
                if (listBox3.SelectedItem != null)
                {
                    listBox2.Items.Add(listBox3.SelectedItem);
                    listBox3.Items.Remove(listBox3.SelectedItem);
                }



                //4->1
                listBox4.SetSelected(0, true);
                if (listBox4.SelectedItem != null)
                {
                    listBox1.Items.Add(listBox4.SelectedItem);
                    listBox4.Items.Remove(listBox4.SelectedItem);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }
    }
}
