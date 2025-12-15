using System;

public partial class Equipos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gvEquipos.DataSource = CL_Equipo.ObtenerEquipos();
            gvEquipos.DataBind();

            ddlUsuarios.DataSource = CL_Usuario.ObtenerUsuarios();
            ddlUsuarios.DataTextField = "Nombre";
            ddlUsuarios.DataValueField = "UsuarioID";
            ddlUsuarios.DataBind();
        }
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        CL_Equipo.AgregarEquipo(txtEquipo.Text, ddlUsuarios.SelectedValue);
        Response.Redirect(Request.RawUrl);
    }

    protected void gvEquipos_RowDeleting(object sender,
        System.Web.UI.WebControls.GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(gvEquipos.DataKeys[e.RowIndex].Value);
        CL_Equipo.EliminarEquipo(id);
        Response.Redirect(Request.RawUrl);
    }
}
