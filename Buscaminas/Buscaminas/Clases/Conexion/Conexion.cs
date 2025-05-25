using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Buscaminas
{
    public static class Conexion
    {
        private static readonly string connectionString = "server=127.0.0.1;database=prueba;uid=usu;pwd=contra;";

        public static MySqlConnection ObtenerConexion()
        {
            try
            {

                MySqlConnection conexion = new MySqlConnection(connectionString);
                conexion.Open();
                return conexion;
            }
            catch (Exception e)
            {
                MessageBox.Show("Falla a la hora de la creacion del canal    " +e.ToString() );
                return null;
            }
        }
    }
}
