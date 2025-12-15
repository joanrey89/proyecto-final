using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class CL_Equipo
{
    static string con = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

    public static DataTable ObtenerEquipos()
    {
        string sql = @"SELECT e.EquipoID, e.NombreEquipo, u.Nombre AS NombreUsuario
                       FROM Equipos e
                       INNER JOIN Usuarios u ON e.UsuarioID = u.UsuarioID";

        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
    }

    public static void AgregarEquipo(string nombre, string usuarioID)
    {
        SqlConnection cn = new SqlConnection(con);
        SqlCommand cmd = new SqlCommand(
            "INSERT INTO Equipos(NombreEquipo, UsuarioID) VALUES (@n,@u)", cn);

        cmd.Parameters.AddWithValue("@n", nombre);
        cmd.Parameters.AddWithValue("@u", usuarioID);

        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
    }

    public static void EliminarEquipo(int id)
    {
        SqlConnection cn = new SqlConnection(con);
        SqlCommand cmd = new SqlCommand(
            "DELETE FROM Equipos WHERE EquipoID=@id", cn);

        cmd.Parameters.AddWithValue("@id", id);
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
    }
}
