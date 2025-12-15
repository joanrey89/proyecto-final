using System;
using System.Web.UI;

public partial class Asignaciones : Page
{
    CL_Asignacion logica = new CL_Asignacion();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Cargar();
        }
    }

    void Cargar()
    {
        gvAsignaciones.DataSource = logica.ObtenerAsignaciones();
        gvAsignaciones.DataBind();
    }

    protected void btnAsignar_Click(object sender, EventArgs e)
    {
        int reparacion = int.Parse(txtReparacion.Text);
        int tecnico = int.Parse(txtTecnico.Text);

        logica.AgregarAsignacion(reparacion, tecnico, DateTime.Now);

        txtReparacion.Text = "";
        txtTecnico.Text = "";

        Cargar();
    }
}
