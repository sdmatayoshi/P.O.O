using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_3er_Bim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
Crear una estructura con:
4 botones ✔
2 listas con 10 nombres en cada una (Ya tienen que estar ingresados en el diseño) ✔

1. Cuando se presiona en el primer boton ordenar los listados ✔
2. Con el segundo boton borran todos los nombres que tengan hasta 5 letras
3. Con el tercer boton intercambiar los nombres que tengan hasta 5 letras
4. Intercambiar el primer y ultimo elemento de ambas listas. Tienen que quedar en el primer lugar y en el ultimo ✔
*/

        private void Form1_Load(object sender, EventArgs e)
        {
            リスト１.Items.Add("Calliope");
            リスト１.Items.Add("Gura");
            リスト１.Items.Add("Kiara");
            リスト１.Items.Add("Amelia");
            リスト１.Items.Add("Kronii");
            リスト１.Items.Add("Sana");
            リスト１.Items.Add("Fauna");
            リスト１.Items.Add("Mumei");
            リスト１.Items.Add("Fuwawa");
            リスト１.Items.Add("Mococo");

            リスト２.Items.Add("Fubuki");
            リスト２.Items.Add("Okayu");
            リスト２.Items.Add("Korone");
            リスト２.Items.Add("Marine");
            リスト２.Items.Add("Iofi");
            リスト２.Items.Add("Moona");
            リスト２.Items.Add("Pekora");
            リスト２.Items.Add("Chloe");
            リスト２.Items.Add("La+");
            リスト２.Items.Add("Haachama");
        }

        private void ボタン１_Click(object sender, EventArgs e)
        {
            リスト１.Sorted = true;
            リスト２.Sorted = true;
        }

        private void ボタン２_Click(object sender, EventArgs e)
        {
            for (int i= リスト１.Items.Count - 1; i>0 ;i--)
            {
                if (リスト１.Items[i].ToString().Length <= 5)
                {
                    リスト１.Items.RemoveAt(i);
                }
            }
            for (int i = リスト２.Items.Count - 1; i > 0; i--)
            {
                if (リスト２.Items[i].ToString().Length <= 5)
                {
                    リスト２.Items.RemoveAt(i);
                }
            }
        }

        private void ボタン３_Click(object sender, EventArgs e)
        {
            for (int i = リスト１.Items.Count - 1; i > 0; i--)
            {
                if (リスト１.Items[i].ToString().Length <= 5)
                {
                    リスト３.Items.Add(リスト１.Items[i]);
                    リスト１.Items.RemoveAt(i);
                }
            }
            for (int i = リスト２.Items.Count - 1; i > 0; i--)
            {
                if (リスト２.Items[i].ToString().Length <= 5)
                {
                    リスト４.Items.Add(リスト２.Items[i]);
                    リスト２.Items.RemoveAt(i);
                }
            }


            for (int i = リスト３.Items.Count-1; i > 0; i--)
            {
                    リスト２.Items.Add(リスト３.Items[i]);
            }
            
            for (int i = リスト４.Items.Count-1; i > 0; i--)
            {
                リスト１.Items.Add(リスト４.Items[i]);
            }
            リスト３.Items.Clear();
            リスト４.Items.Clear();


        }

        private void ボタン４_Click(object sender, EventArgs e)
        {
            リスト１.SelectedIndex = 0;
            リスト２.SelectedIndex = 0;

            リスト３.Items.Add(リスト１.SelectedItem);
            リスト１.Items.Remove(リスト１.SelectedItem);

            リスト４.Items.Add(リスト２.SelectedItem);
            リスト２.Items.Remove(リスト２.SelectedItem);



            リスト１.SelectedIndex = リスト１.Items.Count-1;
            リスト２.SelectedIndex = リスト２.Items.Count-1;

            リスト５.Items.Add(リスト１.SelectedItem);
            リスト１.Items.Remove(リスト１.SelectedItem);
            リスト６.Items.Add(リスト２.SelectedItem);
            リスト２.Items.Remove(リスト２.SelectedItem);


            リスト３.SelectedIndex = 0;
            リスト４.SelectedIndex = 0;
            リスト２.Items.Insert(0, リスト３.SelectedItem);
            リスト３.Items.Clear();
            リスト１.Items.Insert(0, リスト４.SelectedItem);
            リスト４.Items.Clear();

            リスト５.SelectedIndex = 0;
            リスト６.SelectedIndex = 0;
            リスト２.Items.Add(リスト５.SelectedItem);
            リスト５.Items.Clear();
            リスト１.Items.Add(リスト６.SelectedItem);
            リスト６.Items.Clear();
        }
    }
}
