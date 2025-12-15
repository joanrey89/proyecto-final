
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto_2
{
    public partial class Reportes : System.Web.UI.Page
    {
        private CL_Reparacion logicaReparacion = new CL_Reparacion();
        private CL_Usuario logicaUsuario = new CL_Usuario();
        private CL_Equipo logicaEquipo = new CL_Equipo();
        private CL_Tecnico logicaTecnico = new CL_Tecnico();
        private CL_Asignacion logicaAsignacion = new CL_Asignacion();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CD_Usuario.nombre))
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                ConfigurarFechasPorDefecto();
                CargarInformacionReporte();
                CargarReporteReparaciones();
            }
        }

        // ========== CONFIGURAR FECHAS POR DEFECTO ==========
        private void ConfigurarFechasPorDefecto()
        {
            // Fecha de inicio: primer día del mes actual
            txtFechaInicio.Text = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToString("yyyy-MM-dd");

            // Fecha de fin: hoy
            txtFechaFin.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        // ========== CARGAR INFORMACIÓN DEL REPORTE ==========
        private void CargarInformacionReporte()
        {
            try
            {
                // Fecha de generación
                lblFechaGeneracion.InnerText = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                // Usuario que genera
                lblUsuarioGenerador.InnerText = CD_Usuario.nombre + " (" + CD_Usuario.usuario + ")";

                // Período del reporte
                if (!string.IsNullOrEmpty(txtFechaInicio.Text) && !string.IsNullOrEmpty(txtFechaFin.Text))
                {
                    lblPeriodoReporte.InnerText = txtFechaInicio.Text + " al " + txtFechaFin.Text;
                }
                else
                {
                    lblPeriodoReporte.InnerText = "Todo el histórico";
                }


            }
            catch (Exception ex)
            {
                // Si hay error, mostramos información básica
                lblFechaGeneracion.InnerText = DateTime.Now.ToString("dd/MM/yyyy");
                lblUsuarioGenerador.InnerText = "Usuario: " + CD_Usuario.nombre;
            }
        }

        // ========== CARGAR REPORTE DE REPARACIONES ==========
        private void CargarReporteReparaciones()
        {
            try
            {
                DataTable dt = logicaReparacion.ObtenerReparaciones();
                gvReporteReparaciones.DataSource = dt;
                gvReporteReparaciones.DataBind();

                // Actualizar total de registros
                lblTotalRegistros.InnerText = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                // En caso de error, mostramos mensaje
                gvReporteReparaciones.DataSource = null;
                gvReporteReparaciones.DataBind();
                lblTotalRegistros.InnerText = "Error al cargar";
            }
        }

        // ========== FILTRAR POR FECHA ==========
        protected void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio, fechaFin;

                // Validar fechas
                if (!DateTime.TryParse(txtFechaInicio.Text, out fechaInicio) ||
                    !DateTime.TryParse(txtFechaFin.Text, out fechaFin))
                {
                    MostrarMensaje("❌ Formato de fecha inválido", "error");
                    return;
                }

                if (fechaInicio > fechaFin)
                {
                    MostrarMensaje("❌ La fecha de inicio no puede ser mayor a la fecha fin", "error");
                    return;
                }


                CargarInformacionReporte();
                MostrarMensaje("✅ Filtro aplicado correctamente", "success");

                // Actualizar período en el reporte
                lblPeriodoReporte.InnerText = $"{fechaInicio:dd/MM/yyyy} al {fechaFin:dd/MM/yyyy}";
            }
            catch (Exception ex)
            {
                MostrarMensaje("❌ Error al aplicar filtro: " + ex.Message, "error");
            }
        }

        // ========== LIMPIAR FILTRO ==========
        protected void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            ConfigurarFechasPorDefecto();
            CargarInformacionReporte();
            CargarReporteReparaciones();
            MostrarMensaje("🧹 Filtro limpiado", "info");
        }

        // ========== EXPORTAR A PDF ==========
        protected void btnExportarPDF_Click(object sender, EventArgs e)
        {
            MostrarMensaje("📄 Generando reporte PDF...", "info");

        }

        // ========== EXPORTAR A EXCEL ==========
        protected void btnExportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Configurar respuesta para descargar como Excel
                Response.Clear();
                Response.Buffer = true;
                Response.AddHeader("content-disposition", "attachment;filename=Reporte_Reparaciones.xls");
                Response.Charset = "";
                Response.ContentType = "application/vnd.ms-excel";

                // Renderizar GridView a HTML
                System.IO.StringWriter sw = new System.IO.StringWriter();
                System.Web.UI.HtmlTextWriter hw = new System.Web.UI.HtmlTextWriter(sw);

                gvReporteReparaciones.RenderControl(hw);

                // Escribir contenido
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
            catch (Exception ex)
            {
                MostrarMensaje("❌ Error al exportar a Excel: " + ex.Message, "error");
            }
        }

        // ========== EXPORTAR A CSV ==========
        protected void btnExportarCSV_Click(object sender, EventArgs e)
        {
            MostrarMensaje("📁 Generando archivo CSV...", "info");
            // Lógica para exportar a CSV
        }

        // ========== PAGINACIÓN ==========
        protected void gvReporteReparaciones_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvReporteReparaciones.PageIndex = e.NewPageIndex;
            CargarReporteReparaciones();
        }

        // ========== MOSTRAR MENSAJE ==========
        private void MostrarMensaje(string mensaje, string tipo)
        {
            // En esta página usaremos JavaScript para mostrar mensajes
            string script = $@"
                <script>
                    // Crear elemento de mensaje
                    var divMensaje = document.createElement('div');
                    divMensaje.className = 'mensaje {tipo}';
                    divMensaje.innerHTML = '{mensaje}';
                    divMensaje.style.position = 'fixed';
                    divMensaje.style.top = '20px';
                    divMensaje.style.right = '20px';
                    divMensaje.style.zIndex = '1000';
                    divMensaje.style.maxWidth = '300px';
                    
                    // Agregar al body
                    document.body.appendChild(divMensaje);
                    
                    // Remover después de 5 segundos
                    setTimeout(function() {{
                        divMensaje.remove();
                    }}, 5000);
                </script>";

            ClientScript.RegisterStartupScript(this.GetType(), "MostrarMensaje", script);
        }

        // ========== NECESARIO PARA EXPORTAR A EXCEL ==========
        public override void VerifyRenderingInServerForm(Control control)
        {
            // Requerido para evitar error al exportar GridView a Excel
        }
    }
}