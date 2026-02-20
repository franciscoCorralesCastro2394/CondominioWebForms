using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using tarea_1_condominio.Models;
using tarea_1_condominio.Services;

namespace tarea_1_condominio.Pages.Actividades
{
    public partial class Actividades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            String resultado = string.Empty;

            if (ddlTipoActividad.SelectedValue == "Reunion")
            {
                Reunion reunion = new Reunion
                {
                    Titulo = txtTitulo.Text,
                    EsParaTodos = chkTodos.Checked,
                    FechaPublicacion = DateTime.Parse(txtFechaPublicacion.Text),
                    FechaCierre = DateTime.Parse(txtFechaCierre.Text),
                    FechaHoraReunion = DateTime.Parse(txtFechaReunion.Text),
                    DuracionEstimada = txtDuracion.Text,
                    Agenda = txtAgenda.Text,
                    UbicacionPresencial = txtUbicacionPresencial.Text,
                    EnlaceVirtual = txtEnlaceVirtual.Text
                };

                resultado = ActividadService.AgregarActividad(reunion);
            }

            if (ddlTipoActividad.SelectedValue == "Social")
            {
                ActividadSocial actividad = new ActividadSocial
                {
                    Titulo = txtTitulo.Text,
                    EsParaTodos = chkTodos.Checked,
                    FechaPublicacion = DateTime.Parse(txtFechaPublicacion.Text),
                    FechaCierre = DateTime.Parse(txtFechaCierre.Text),
                    FechaInicio = DateTime.Parse(txtFechaInicio.Text),
                    FechaFin = DateTime.Parse(txtFechaFin.Text),
                    Ubicacion = txtUbicacionSocial.Text,
                    Formato = ddlFormato.Text,
                    Instrucciones = txtInstrucciones.Text
                };

                resultado = ActividadService.AgregarActividad(actividad);
            }

            if (ddlTipoActividad.SelectedValue == "Recordatorio")
            {
                Recordatorio recordatorio = new Recordatorio
                {
                    Titulo = txtTitulo.Text,
                    EsParaTodos = chkTodos.Checked,
                    FechaPublicacion = DateTime.Parse(txtFechaPublicacion.Text),
                    FechaCierre = DateTime.Parse(txtFechaCierre.Text),
                    Descripcion = txtDescripcionRecordatorio.Text

                };

                resultado = ActividadService.AgregarActividad(recordatorio);
            }


            if (resultado.Contains("Error"))
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblMensaje.ForeColor = System.Drawing.Color.Green;
            }

            lblMensaje.Text = resultado;

        }
    }
}