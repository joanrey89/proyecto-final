using System;
using System.Data;

public partial class Usuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            CargarUsuarios();
    }

    void CargarUsuarios()
    {
        gvUsuarios.DataSource = CL_Usuario.ObtenerUsuarios();
        gvUsuarios.DataBind();
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        CL_Usuario.AgregarUsuario(
            txtNombre.Text,
            txtCorreo.Text,
            txtTelefono.Text,
            txtClave.Text);

        CargarUsuarios();
    }

    protected void gvUsuarios_RowDeleting(object sender,
        System.Web.UI.WebControls.GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(gvUsuarios.DataKeys[e.RowIndex].Value);
        CL_Usuario.EliminarUsuario(id);
        CargarUsuarios();
    }
}
