using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace proyecto_2.CapaDatos
{
    public class CD_Usuario
    {
        public static string nombre;

        public static bool Validar(string usuario, string clave)
        {
            bool valido = false;

            try
            {
                // Obtener cadena de conexión
                string connectionString = ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;

                // Crear conexión
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Crear comando SQL
                    string sql = "SELECT Nombre FROM Usuarios WHERE CorreoElectronico = @usuario AND Clave = @clave";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    // Agregar parámetros
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@clave", clave);

                    // Abrir conexión y ejecutar
                    con.Open();
                    object resultado = cmd.ExecuteScalar();

                    // Verificar resultado
                    if (resultado != null)
                    {
                        nombre = resultado.ToString();
                        valido = true;
                    }
                }
            }
            catch
            {
                valido = false;
            }

            return valido;
        }
    }
}