using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;
using WindowsFormsApp1.Servicios;

namespace Buscaminas.Formas
{
    public partial class ReinicarSeleccionCola : Form
    {
        private ColaDificultad cola;
        private NodoDificultad nodoActual;

        public ReinicarSeleccionCola()
        {
            InitializeComponent();

            CargarDatos();
        }

        private void CargarDatos()
        {
            List<Dificultad> dificultades = ServicioDificultad.ObtenerDificultades();

            cola = new ColaDificultad();
            foreach (var dificultad in dificultades)
            {
                cola.Push(dificultad);
            }

            nodoActual = cola.GetCabeza();
            MostrarDatosNodo(nodoActual);
        }

        private void MostrarDatosNodo(NodoDificultad nodo)
        {
            if (nodo != null && nodo.Valor != null)
            {
                dificultadNombreBoton.Text = nodo.Valor.Nombre;
                filasTextBox.Text = nodo.Valor.Filas.ToString();
                columnasTextbox.Text = nodo.Valor.Columnas.ToString();
                minasTextBox.Text = nodo.Valor.Minas.ToString();
            }
        }


        private void atrasBoton_Click_1(object sender, EventArgs e)
        {
            if (nodoActual != null && nodoActual.anterior != null)
            {
                nodoActual = nodoActual.anterior;
                MostrarDatosNodo(nodoActual);
            }
            else
            {
                MessageBox.Show("Ya estas en la primera dificultad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void siguienteBoton_Click_1(object sender, EventArgs e)
        {
            if (nodoActual != null && nodoActual.siguiente != null)
            {
                nodoActual = nodoActual.siguiente;
                MostrarDatosNodo(nodoActual);
            }
            else
            {
                MessageBox.Show("Ya estas en la ultima dificultad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
