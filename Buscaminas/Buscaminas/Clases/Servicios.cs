using MySql.Data.MySqlClient;
using System;
using System.Data;
namespace Buscaminas
{
    public class Servicios
    {


        public static void GuardarResultado(string nombreJugador, int movimientos, bool gano)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string query = "INSERT INTO Buscaminas (nombreJugador, movimientos, gano) VALUES (@nombre, @movimientos, @gano)";
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@nombre", nombreJugador);
                    comando.Parameters.AddWithValue("@movimientos", movimientos);
                    comando.Parameters.AddWithValue("@gano", gano ? 1 : 0);
                    comando.ExecuteNonQuery();
                }
            }
            catch(Exception e)
            {

            }
        }

        public static DataTable ObtenerResultados()
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string query = "SELECT idBuscaminas, nombreJugador, movimientos, gano FROM Buscaminas";
                using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion))
                {

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
        }

        public static void ActualizarResultado(int id, string nombre, int movimientos, int gano)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string query = "UPDATE Buscaminas SET nombreJugador = @nombre, movimientos = @movs, gano = @gano WHERE idBuscaminas = @id";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@movs", movimientos);
                comando.Parameters.AddWithValue("@gano", gano);
                comando.ExecuteNonQuery();
            }
        }


        public static void EliminarResultado(int id)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string query = "DELETE FROM Buscaminas WHERE idBuscaminas = @id";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
            }
        }


    }
}
