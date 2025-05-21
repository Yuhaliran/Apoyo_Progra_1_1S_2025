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
            InicializarEventos();
            CargarResultados();
        }

        private void InicializarEventos()
        {
            dataGridView1.KeyDown += DataGridView1_KeyDown;

        }


        private void CargarResultados()
        {
            try
            {
                DataTable dt = Servicios.ObtenerResultados();
                dataGridView1.DataSource = dt;

                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns["nombreJugador"].HeaderText = "Jugador";
                dataGridView1.Columns[2].HeaderText = "Movimientos";
                dataGridView1.Columns["gano"].HeaderText = "Gano?";



                dataGridView1.Columns[0].ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar resultados " + ex.Message);
            }
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;
                    //validaciones
                    //validacion del nombre vacio
                    if (row.Cells["nombreJugador"].Value == null || string.IsNullOrWhiteSpace(row.Cells["nombreJugador"].Value.ToString()))
                    {
                        MessageBox.Show("El nombre del jugador no puede estar vacio", "validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //validacion de la cantidad de movimientos
                    if (!int.TryParse(row.Cells["movimientos"].Value?.ToString(), out int movimientos))
                    {
                        MessageBox.Show("Los movimientos deben ser un numero valido", "validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    //validacion de si gano o no
                    if (!int.TryParse(row.Cells["gano"].Value?.ToString(), out int gano))
                    {
                        MessageBox.Show("Gano debe ser 0 o 1", "validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int id = Convert.ToInt32(row.Cells["idBuscaminas"].Value);
                    string nombre = row.Cells["nombreJugador"].Value.ToString();

                    Servicios.ActualizarResultado(id, nombre, movimientos, gano);
                }

                MessageBox.Show("Cambios guardados correctamente");
                CargarResultados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios  " + ex.Message);
            }
        }



        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("desea eliminar este registro?", "Confirmar eliminacion", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idBuscaminas"].Value);
                    try
                    {
                        Servicios.EliminarResultado(id);
                        CargarResultados();
                        MessageBox.Show("Registro eliminado.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona una fila para eliminar.");
            }
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                if (dataGridView1.IsCurrentCellInEditMode)
                {
                    dataGridView1.EndEdit();
                }

                BtnGuardarCambios_Click(null, null);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
