using Mysqlx.Resultset;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Basico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CargarResultados();
        }

        public void CargarResultados()
        {
            try
            {
                DataTable dt = Servicios.ObtenerTodosLosResultados();

                dataGridView1.DataSource = dt;

                dataGridView1.Columns["IdBuscaminas"].HeaderText = "IdBuscaminas";
                dataGridView1.Columns["nombreJugador"].HeaderText = "nombreJugador";
                dataGridView1.Columns["movimientos"].HeaderText = "movimientos";
                dataGridView1.Columns["gano"].HeaderText = "gano";

                dataGridView1.Columns[0].ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar informacion desde la forma, por:  " + ex.ToString());
            }
        }

        private void actualizarInformacion(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

            int id = Convert.ToInt32(fila.Cells["idBuscaminas"].Value);
            string nombre = fila.Cells["nombreJugador"].Value.ToString();
            int movimientos = Convert.ToInt32(fila.Cells["movimientos"].Value);
            bool gano = Convert.ToBoolean(fila.Cells["gano"].Value);

            Servicios.ActulizarInformacion(id,nombre,movimientos,gano);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count ==1)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdBuscaminas"].Value);

                Servicios.EliminarResultados(id);
                MessageBox.Show("Se ha eliminado el dato: " + id);

                CargarResultados();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarResultados();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Servicios.ObtenerResultadosFiltradosPorMovimientos(3);

                dataGridView1.DataSource = dt;

                dataGridView1.Columns["IdBuscaminas"].HeaderText = "IdBuscaminas";
                dataGridView1.Columns["nombreJugador"].HeaderText = "nombreJugador";
                dataGridView1.Columns["movimientos"].HeaderText = "movimientos";
                dataGridView1.Columns["gano"].HeaderText = "gano";

                dataGridView1.Columns[0].ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar informacion desde la forma, por:  " + ex.ToString());
            }
        }
    }
}
