using System;
using System.Web.UI;

public partial class MenuPrincipal : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Usuario"] == null)
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void IrAsignaciones(object sender, EventArgs e)
    {
        Response.Redirect("Asignaciones.aspx");
    }

    protected void IrEquipo(object sender, EventArgs e)
    {
        Response.Redirect("Equipo.aspx");
    }

    protected void IrReparaciones(object sender, EventArgs e)
    {
        Response.Redirect("Reparaciones.aspx");
    }

    protected void IrUsuarios(object sender, EventArgs e)
    {
        Response.Redirect("Usuarios.aspx");
    }

    protected void btnSalir_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        Response.Redirect("Login.aspx");
    }
}