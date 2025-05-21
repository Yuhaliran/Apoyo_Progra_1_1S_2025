using MemoriaDinamica.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoriaDinamica
{
    public partial class Form1 : Form
    {
        private Cola cola = new Cola();
        private Pila pila = new Pila();

        public Form1()
        {
            InitializeComponent();
        }

        private void PushCola(object sender, EventArgs e)
        {
            cola.Push(new Unidad(cola.GetTamanio()));
            dibujarCola();

        }

        private void MostrarCantidadEnCola(object sender, EventArgs e)
        {
            MessageBox.Show("Hay :" + cola.GetTamanio().ToString() + " elementos en cola");
        }

        private void PopCola(object sender, EventArgs e)
        {
            if (cola.GetTamanio() != 0)
            {
                MessageBox.Show("Se ha eliminado:" + cola.Pop().dato.ToString());
                dibujarCola();
            }
            else
            {
                MessageBox.Show("Cola Vacia");

            }
        }

        public void dibujarCola()
        {
            foreach (Control control in this.Controls.OfType<Button>().ToList())
            {
                if (control.Tag?.ToString() == "cola" || control.Tag?.ToString() == "pila")
                {
                    this.Controls.Remove(control);
                }
            }

            Unidad[] elementos = cola.ObtenerTodo();

            int espacio = 60;

            int i = 0;

            for (i = 0; i < elementos.Length; i++)
            {
                Button btn = new Button();

                btn.Text = elementos[i].dato.ToString();
                btn.Width = 50;
                btn.Height = 50;
                btn.Left = 10 + (i * espacio);
                btn.Top = 10;
                btn.Tag = "cola";

                this.Controls.Add(btn);
            }
        }

        private void dibujarColaBoton_Click(object sender, EventArgs e)
        {
            dibujarCola();
        }

        private void pushPilaBoton_Click(object sender, EventArgs e)
        {
            pila.Push(new Unidad(pila.GetTamanio()));
            dibujarPila();
        }

        private void mostrarTamanioPilaBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hay :" + pila.GetTamanio().ToString() + " elementos en cola");
        }

        private void popPilaBoton_Click(object sender, EventArgs e)
        {
            if (pila.GetTamanio() != 0)
            {
                MessageBox.Show("Se ha eliminado:" + pila.Pop().dato.ToString());
                dibujarPila();
            }
            else
            {
                MessageBox.Show("Pila Vacia");

            }
        }

        private void dibujarPilaBoton_Click(object sender, EventArgs e)
        {
            dibujarPila();
        }

        private void dibujarPila()
        {
            foreach (Control control in this.Controls.OfType<Button>().ToList())
            {
                if (control.Tag?.ToString() == "cola" || control.Tag?.ToString() == "pila")
                {
                    this.Controls.Remove(control);
                }
            }

            Unidad[] elementos = pila.ObtenerTodos();

            int espacio = 60;

            int i = 0;

            for (i = 0; i < elementos.Length; i++)
            {
                Button btn = new Button();

                btn.Text = elementos[i].dato.ToString();
                btn.Width = 50;
                btn.Height = 50;
                btn.Left = 10 + (i * espacio);
                btn.Top = 10;
                btn.Tag = "pila";

                this.Controls.Add(btn);
            }
        }
    }
}
