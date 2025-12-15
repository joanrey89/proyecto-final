using System.Data;
using System.Data.SqlClient;

namespace proyecto_2.CapaDatos
{
    public class CD_Reparacion
    {
        public static DataTable Listar()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT ReparacionID, Descripcion, Estado FROM Reparaciones",
                    con
                );

                da.Fill(tabla);
            }

            return tabla;
        }
    }
}
