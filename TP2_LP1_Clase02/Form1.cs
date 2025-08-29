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
    public partial class Form1 : Form
    {
        public int[] numeros;
        public int posicion;
        public int ultimoElemento;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ultimoElemento = 0;
            numeros = new int[4];
            //numeros[0] = 4;
            //numeros[1] = 13;
            //numeros[2] = 9;
            //numeros[3] = 1;
            

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    label1.Text += $"{numeros[i]} \n";
            //}

            //Ordenar de menor a mayor
            //Array.Sort(numeros);

            //Invierte orden de arreglo
            //Array.Reverse(numeros);


            //MessageBox.Show($"La posicion es {posicion}");
            //cargarLabel();


        }
        private void cargarLabel()
        {
            label1.Text = string.Empty;
            foreach (int i in numeros)
            {
                if(i > 0)
                {
                    label1.Text += $"{i} \n";
                }
            }
        }
        private void cargarCombo()
        {
            comboBox1.Items.Clear();
            foreach (var item in numeros)
            {
                if(item > 0)
                {
                    comboBox1.Items.Add(item);
                }
            }
            //comboBox1.Items.AddRange(numeros.Cast<object>().ToArray());

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numeroSeleccionado = (int)comboBox1.SelectedItem;
            posicion = Array.IndexOf(numeros, numeroSeleccionado);
            textBox2.Text = numeroSeleccionado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numeros[posicion]=int.Parse(textBox2.Text);
            cargarLabel();
            cargarCombo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int acumulador = 0;
            //foreach (int i in numeros)
            //{
            //    acumulador += i;
            //}
            //double resultado = double.Parse(acumulador.ToString()) / numeros.Length;
            
            //Linq
            //double resultado = numeros.Average();
            double resultado = double.Parse(numeros.Sum().ToString()) / numeros.Length;
            label2.Text = resultado.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int indice = Array.IndexOf(numeros, null);
            //Array.Resize(ref numeros, 5);
            if(ultimoElemento < numeros.Length)
            {
                numeros[ultimoElemento] = int.Parse(textBox1.Text);
                //ultimoElemento = ultimoElemento +1;
                ultimoElemento++;
                cargarLabel();
                cargarCombo();
            }
            else
            {
                MessageBox.Show("El arreglo esta completo");
            }
        }
    }
}
