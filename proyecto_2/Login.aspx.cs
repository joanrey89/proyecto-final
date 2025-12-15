using System;
using System.Web.UI;
using proyecto_2.CapaLogica;

namespace proyecto_2
{
    public partial class Login : Page
    {
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            // Obtener valores
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            // Validar
            bool esValido = CL_Usuario.ValidarUsuario(usuario, clave);

            if (esValido)
            {
                // Guardar en sesión
                Session["Usuario"] = proyecto_2.CapaDatos.CD_Usuario.nombre;
                Response.Redirect("MenuPrincipal.aspx");
            }
            else
            {
                // Mostrar error
                lblMensaje.Text = "❌ Usuario o contraseña incorrectos";
                lblMensaje.Visible = true;
            }
        }
    }
}