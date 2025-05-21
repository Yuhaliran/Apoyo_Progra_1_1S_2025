using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System;
using System.Configuration;

namespace CRUD_Basico
{
    internal class Servicios
    {
        public static void GuardarResultado(string nombreJugador, int movimientos, bool gano)
        {
            try
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "INSERT INTO Buscaminas(nombreJugador,movimientos,gano) VALUES(@nombreJugador, @movimientos, @gano)";

                    MySqlCommand comando = new MySqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@gano", gano);
                    comando.Parameters.AddWithValue("@nombreJugador", nombreJugador);
                    comando.Parameters.AddWithValue("@movimientos", movimientos);

                    comando.ExecuteNonQuery();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar informacion, por:  " + ex.ToString());
            }
        }

        public static DataTable ObtenerResultadosFiltradosPorMovimientos(int maxMovimientos)
        {
            try
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "SELECT idBuscaminas, nombreJugador, movimientos, gano FROM Buscaminas WHERE movimientos <= @mov";

                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@mov", maxMovimientos);

                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            DataTable tablaSalida = new DataTable();
                            adaptador.Fill(tablaSalida);
                            return tablaSalida;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener la informacion filtrada, por:  " + ex.ToString());
                return null;
            }
        }

        public static DataTable ObtenerTodosLosResultados()
        {
            try
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "SELECT idBuscaminas, nombreJugador, movimientos, gano FROM Buscaminas";

                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query,conexion))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        return tabla;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudo obtener toda la informacion, por:  " + ex.ToString());
                return null;
            }
        }

        public static void ActulizarInformacion(int idBuscaminas, string nombreJugador, int movimientos, bool gano)
        {
            try
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "UPDATE Buscaminas SET nombreJugador = @nombreJugador, movimientos = @movimientos, gano = @gano WHERE idBuscaminas = @idBuscaminas";

                    MySqlCommand comando = new MySqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@idBuscaminas", idBuscaminas);
                    comando.Parameters.AddWithValue("@nombreJugador", nombreJugador);
                    comando.Parameters.AddWithValue("@movimientos", movimientos);
                    comando.Parameters.AddWithValue("@gano", gano);

                    comando.ExecuteNonQuery();

                }
            }catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la informacion, por:  " + ex.ToString());
            }
        }

        public static void EliminarResultados(int id)
        {
            try
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "DELETE FROM Buscaminas WHERE idBuscaminas = @idBuscaminas";

                    MySqlCommand comando = new MySqlCommand(query,conexion);

                    comando.Parameters.AddWithValue("@idBuscaminas", id);

                    comando.ExecuteNonQuery ();

                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la informacion, por:  " + ex.ToString());
            }
        }

    }
}
