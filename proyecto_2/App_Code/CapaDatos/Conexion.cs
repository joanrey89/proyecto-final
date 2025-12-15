using System.Configuration;

namespace proyecto_2.CapaDatos
{
    public class Conexion
    {
        public static string cadena =
            ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
    }
}
