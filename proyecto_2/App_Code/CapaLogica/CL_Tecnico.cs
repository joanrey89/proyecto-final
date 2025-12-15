using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class CL_Tecnico
{
    static string con = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

    public static DataTable ObtenerTecnicos()
    {
        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tecnicos", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
    }

    public static void AgregarTecnico(string nombre, string esp)
    {
        SqlConnection cn = new SqlConnection(con);
        SqlCommand cmd = new SqlCommand(
            "INSERT INTO Tecnicos(nombre, especialidad) VALUES (@n,@e)", cn);

        cmd.Parameters.AddWithValue("@n", nombre);
        cmd.Parameters.AddWithValue("@e", esp);

        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
    }

    public static void EliminarTecnico(int id)
    {
        SqlConnection cn = new SqlConnection(con);
        SqlCommand cmd = new SqlCommand(
            "DELETE FROM Tecnicos WHERE TecnicoID=@id", cn);

        cmd.Parameters.AddWithValue("@id", id);
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
    }
}
