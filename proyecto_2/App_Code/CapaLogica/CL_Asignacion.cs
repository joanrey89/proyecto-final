using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class CL_Asignacion
{
    string cnx = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

    public DataTable ObtenerAsignaciones()
    {
        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Asignaciones", cnx);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
    }

    public void AgregarAsignacion(int reparacion, int tecnico, DateTime fecha)
    {
        using (SqlConnection cn = new SqlConnection(cnx))
        {
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Asignaciones (IdReparacion, IdTecnico, FechaAsignacion) VALUES (@r,@t,@f)", cn);

            cmd.Parameters.AddWithValue("@r", reparacion);
            cmd.Parameters.AddWithValue("@t", tecnico);
            cmd.Parameters.AddWithValue("@f", fecha);

            cn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
