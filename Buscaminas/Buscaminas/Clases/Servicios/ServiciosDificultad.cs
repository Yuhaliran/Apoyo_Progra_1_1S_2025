using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using WindowsFormsApp1.Modelos;
using Buscaminas;

namespace WindowsFormsApp1.Servicios
{
    internal class ServicioDificultad
    {
        public static List<Dificultad> ObtenerDificultades()
        {
            List<Dificultad> lista = new List<Dificultad>();

            try
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string query = "SELECT idNivel, nombre, filas, columnas, minas FROM Dificultad";

                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dificultad dif = new Dificultad
                            {
                                IdNivel = Convert.ToInt32(reader["idNivel"]),
                                Nombre = reader["nombre"].ToString(),
                                Filas = Convert.ToInt32(reader["filas"]),
                                Columnas = Convert.ToInt32(reader["columnas"]),
                                Minas = Convert.ToInt32(reader["minas"])
                            };

                            lista.Add(dif);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las dificultades: " + ex.Message);
            }

            return lista;
        }
    }
}
