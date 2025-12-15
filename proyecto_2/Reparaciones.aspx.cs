using proyecto_2.CapaLogica;
using System;
using System.Data;
using System.Web.UI;

namespace proyecto_2
{
    public partial class Reparaciones : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarReparaciones();
            }
        }

        // Cargar datos en el GridView
        private void CargarReparaciones()
        {
            DataTable tabla = CL_Reparacion.Listar();
            gvReparaciones.DataSource = tabla;
            gvReparaciones.DataBind();
        }

        // Evento de botones del Grid
        protected void gvReparaciones_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Asignar")
            {
                int reparacionID = Convert.ToInt32(e.CommandArgument);

                // Redirigir a Asignaciones
                Response.Redirect("Asignaciones.aspx?reparacion=" + reparacionID);
            }
        }
    }
}
