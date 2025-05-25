using Buscaminas.Clases;
using Buscaminas.Formas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;

namespace Buscaminas
{
    public partial class Form1 : Form
    {

        private Tablero tablero; 
        private Button[,] botones; 
        private int filas = 10;     
        private int columnas = 10;  
        private int minas = 10;
        private int movimientos = 0;
        private List<Dificultad> listaDificultades;
        public Form1()
        {
            InitializeComponent();

            InicializarJuego();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InicializarJuego()
        {
            tablero = new Tablero(filas, columnas, minas);
            botones = new Button[filas, columnas];
            Crear_Botones();
        }
         

        private void VerrAyyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AYUDA!!!!!");
        }


        private void Crear_Botones()
        {
            int tamanioBoton = 40;
            int i, j;
            for (i = 0; i < filas; i++)
            {
                for (j = 0; j < columnas; j++)
                {
                    Button boton = new Button
                    {
                        Width = tamanioBoton,
                        Height = tamanioBoton,
                        Location = new Point(j * tamanioBoton, (i * tamanioBoton)+this.menuStrip1.Height),
                        Tag = new Point(i, j)
                    };

                    boton.MouseUp += Boton_cliqueado;

                    this.Controls.Add(boton);
                    botones[i, j] = boton;
                }
            }

            this.ClientSize = new Size(columnas * tamanioBoton, (filas * tamanioBoton)+this.menuStrip1.Height);
        }

        private void Boton_cliqueado(object sender, MouseEventArgs e)
        {
            movimientos++;
            Button botonClicado = sender as Button;
            Point posicion = (Point)botonClicado.Tag;
            int fila = posicion.X;
            int columna = posicion.Y;
            Celda celda = tablero.Celdas[fila, columna];

            if (e.Button == MouseButtons.Right)
            {
                if (!celda.EstaDescubierta)
                {
                    celda.TieneBandera = !celda.TieneBandera;
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (celda.TieneMina)
                {
                    botonClicado.BackColor = Color.Red;
                    RevelarTablero();

                    using (var inputForm = new Form())
                    {
                        inputForm.Text = "Fin del juego";
                        inputForm.Size = new Size(300, 150);
                        inputForm.StartPosition = FormStartPosition.CenterParent;

                        var label = new Label() { Text = "Has perdido. Ingresa tu nombreJugador:", Left = 10, Top = 10, Width = 250 };
                        var textbox = new TextBox() { Left = 10, Top = 35, Width = 250 };
                        var buttonAceptar = new Button() { Text = "Aceptar", Left = 180, Top = 65, Width = 80 };

                        buttonAceptar.DialogResult = DialogResult.OK;
                        inputForm.Controls.Add(label);
                        inputForm.Controls.Add(textbox);
                        inputForm.Controls.Add(buttonAceptar);
                        inputForm.AcceptButton = buttonAceptar;

                        if (inputForm.ShowDialog() == DialogResult.OK)
                        {
                            string nombreJugador = textbox.Text;
                            if (!string.IsNullOrWhiteSpace(nombreJugador))
                            {
                                
                                ServiciosResultados.GuardarResultado(nombreJugador, movimientos, false);
                                MessageBox.Show("Resultado guardado.");
                            }
                        }
                    }

                    MessageBox.Show("Perdiste");

                    movimientos = 0;
                }
                else
                {
                    DescubrirCelda(fila, columna);
                }
            }
        }


        private void DescubrirCelda(int fila, int columna)
        {
            Celda celda = tablero.Celdas[fila, columna];
            if (celda.EstaDescubierta || celda.TieneBandera)
                return;

            celda.EstaDescubierta = true;
            Button boton = botones[fila, columna];
            boton.Enabled = false;
            boton.BackColor = Color.LightGray;

            if (celda.MinasAlrededor > 0)
            {
                boton.Text = celda.MinasAlrededor.ToString();
            }
            else
            {
               for (int i = fila - 1; i <= fila + 1; i++)
                {
                    for (int j = columna - 1; j <= columna + 1; j++)
                    {
                        if (i >= 0 && i < filas && j >= 0 && j < columnas)
                        {
                            DescubrirCelda(i, j);
                        }
                    }
                }
            }
        }

        private void RevelarTablero()
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Celda celda = tablero.Celdas[i, j];
                    Button boton = botones[i, j];

                    if (celda.TieneMina)
                    {
                        boton.BackColor = Color.LightCoral;
                    }
                    else if (celda.MinasAlrededor > 0)
                    {
                        boton.Text = celda.MinasAlrededor.ToString();
                        boton.BackColor = Color.LightGray;
                    }

                    boton.Enabled = false;
                }
            }
        }

        private void ReiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reiniciar_Click(sender, e);
        }

        private void AyudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buscaminas\n\nHaz clic izquierdo para descubrir una celda.\nHaz clic derecho para colocar una bandera.\nEvita las minas.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Reiniciar_Click(object sender, EventArgs e)
        {
            ReinicarSeleccionCola reiniciar = new ReinicarSeleccionCola();

            reiniciar.ShowDialog();
        }

        private void LimpiarTablero()
        {
            if (botones != null)
            {
                foreach (Button b in botones)
                {
                    this.Controls.Remove(b);
                    b.Dispose();
                }
            }
        }

        private void ReinicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reiniciar_Click(sender, e);
        }

        private void VerAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buscaminas\n\nHaz clic izquierdo para descubrir una celda.\nHaz clic derecho para colocar una bandera.\nEvita las minas.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void VerArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reiniciar_Click(sender, e);
        }

        private void RegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultadosForm resultadosForm = new ResultadosForm();
            resultadosForm.ShowDialog();
        }
    }
}
