using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_LP1_Clase02
{
    public partial class Form2 : Form
    {
        public string[] tiros;
        public Tiro[] dados;
        public int posicion;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (posicion < 3)
            {
                Random random = new Random();
                Tiro tiro = new Tiro();
                tiro.dado1 = random.Next(1, 6);
                tiro.dado2 = random.Next(1, 6);
                tiro.dado3 = random.Next(1, 6);
                tiro.dado4 = random.Next(1, 6);
                tiro.dado5 = random.Next(1, 6);
                dados[posicion] = tiro;
                posicion++;
                mostrarLabel();
            }

            //    if (posicion <3 )
            //{
            //    string tiro = string.Empty;
            //    Random random = new Random();
            //    for (int i = 0; i < 5; i++)
            //    {
            //        int numero = random.Next(1, 6);
            //        tiro += numero + "-";
            //    }
            //    tiros[posicion] = tiro;
            //    posicion++;
            //    mostrarLabel();
            //}
            else
            {
                MessageBox.Show("Ha alcanzado el maximo numero de tiros");
            }
        }
        private void mostrarLabel()
        {
            label1.Text = string.Empty;
            foreach (Tiro tiro in dados)
            {
                if(tiro != null)
                {
                    label1.Text += tiro.dado1 + "-"+ tiro.dado2 + "-"+ tiro.dado3 + "-"+ tiro.dado4 + "-"+ tiro.dado5 + "\n";
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dados = new Tiro[3];
            tiros = new string[3];
            posicion = 0;
        }
    }
}
