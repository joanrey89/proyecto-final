using System.Data.SqlClient;
using System.Configuration;

public class CL_Reportes
{
    static string con = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

    public static int Total(string tabla)
    {
        SqlConnection cn = new SqlConnection(con);
        SqlCommand cmd = new SqlCommand(
            "SELECT COUNT(*) FROM " + tabla, cn);

        cn.Open();
        int total = (int)cmd.ExecuteScalar();
        cn.Close();

        return total;
    }
}
