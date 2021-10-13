using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intercabiar_Pilas
{
    public partial class Form1 : Form
    {
        Pila mensajero = new Pila();
        Pila mensajero2 = new Pila();


        public void mostrarPila()
        {
            listView1.Clear();
            for (int i = 0; i <= mensajero.tope; i++)
            {
                listView1.Items.Add(mensajero.lista[i].ToString());

            }
        }
        public void mostrarPila2()
        {
            listView2.Clear();
            for (int j = 0; j <= mensajero2.tope; j++)
            {
                listView2.Items.Add(mensajero2.lista[j].ToString());

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mensajero.insertar(Int32.Parse (textBox1.Text));
            textBox1.Focus();
            textBox1.Clear();
            mostrarPila();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mensajero.eliminar();
            mostrarPila();
        }



        //Pila2
        private void button3_Click(object sender, EventArgs e)
        {
            mensajero2.insertar(Int32.Parse(textBox2.Text));
            textBox2.Clear();
            textBox2.Focus();
            mostrarPila2();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            mensajero2.eliminar();
            mostrarPila2();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Intercambio intercambio = new Intercambio();
            intercambio.intercambiar(mensajero,mensajero2);
            mostrarPila();
            mostrarPila2();
        }
    }
}
