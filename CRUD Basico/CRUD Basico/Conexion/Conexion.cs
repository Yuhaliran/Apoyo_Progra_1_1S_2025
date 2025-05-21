using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

namespace CRUD_Basico
{
    internal class Conexion
    {
        private static readonly string connectionString = "server=localhost;database=prueba;uid=usu;pwd=contra";

        public static MySqlConnection ObtenerConexion()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(connectionString);
                conexion.Open();
                return conexion;
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudo coneectar a la DB, por:  " + ex.ToString());
                return null;
            }
        }
    }
}
