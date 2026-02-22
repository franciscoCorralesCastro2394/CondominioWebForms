using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tarea_1_condominio.Models;
using tarea_1_condominio.Services;

namespace tarea_1_condominio.Pages.Actividades
{
    public partial class Detalles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("~/Pages/Actividades.aspx");
                return;
            }

            
            String id = Convert.ToString(Request.QueryString["id"]);


            var actividad = ActividadService.ListaActividades
            .FirstOrDefault(a => a.Id == id);

            if (actividad == null)
            {
                Response.Redirect("~/Pages/Actividades.aspx");
                return;
            }


            // Datos comunes
            lblTitulo.Text = actividad.Titulo;
            lblPublicacion.Text = actividad.FechaPublicacion.ToShortDateString();
            lblCierre.Text = actividad.FechaCierre.ToShortDateString();
            lblCreadoPor.Text = actividad.Creador;

            // Datos específicos según tipo
            if (actividad is Reunion reunion)
            {
                pnlReunion.Visible = true;
                lblFechaReunion.Text = reunion.FechaHoraReunion.ToString();
            }

            if (actividad is ActividadSocial social)
            {
                pnlSocial.Visible = true;
                lblInicio.Text = social.FechaInicio.ToString();
                lblFin.Text = social.FechaFin.ToString();
            }

            if (actividad is Recordatorio recordatorio)
            {
                pnlRecordatorio.Visible = true;
                lblDescripcion.Text = recordatorio.Descripcion;
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Actividades/Actividades.aspx");
        }
    }
}