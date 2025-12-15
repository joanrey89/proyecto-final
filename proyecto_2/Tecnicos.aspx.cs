using System;
using System.Data;
public partial class Tecnicos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            gvTecnicos.DataSource = CL_Tecnico.ObtenerTecnicos();
        gvTecnicos.DataBind();
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        CL_Tecnico.AgregarTecnico(txtNombre.Text, txtEspecialidad.Text);
        Response.Redirect(Request.RawUrl);
    }

    protected void gvTecnicos_RowDeleting(object sender,
        System.Web.UI.WebControls.GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(gvTecnicos.DataKeys[e.RowIndex].Value);
        CL_Tecnico.EliminarTecnico(id);
        Response.Redirect(Request.RawUrl);
    }
}
