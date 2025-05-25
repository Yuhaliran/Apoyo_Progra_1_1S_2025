using System;
using System.Data;
using System.Windows.Forms;

namespace Buscaminas
{
    public partial class ResultadosForm : Form
    {
        public ResultadosForm()
        {
            InitializeComponent();
            CargarResultados();
        }

        private void CargarResultados()
        {
            try
            {
                DataTable dt = ServiciosResultados.ObtenerTodosLosResultados();

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

            ServiciosResultados.ActulizarInformacion(id, nombre, movimientos, gano);
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdBuscaminas"].Value);

                ServiciosResultados.EliminarResultados(id);
                MessageBox.Show("Se ha eliminado el dato: " + id);

                CargarResultados();
            }
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
