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
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verificar si se ha proporcionado un ID en la consulta
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("~/Pages/Actividades.aspx");
                return;
            }

            string id = Request.QueryString["id"];

            var actividad = ActividadService.ListaActividades
                .FirstOrDefault(a => a.Id == id);

            if (actividad == null)
            {
                Response.Redirect("~/Pages/Actividades.aspx");
                return;
            }

            // Cargar los datos de la actividad en los campos del formulario
            txtTitulo.Text = actividad.Titulo;
            txtPublicacion.Text = actividad.FechaPublicacion.ToString("yyyy-MM-dd");
            txtCierre.Text = actividad.FechaCierre.ToString("yyyy-MM-dd");
        }



        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            string resltado = string.Empty;
            // Validación de campos
            var actividadExisting = ActividadService.ListaActividades
                .FirstOrDefault(a => a.Id == id);
            // Verificar si la actividad existe
            if (actividadExisting == null)
            {
                resltado = "Error Actividad no encontrada";
            }

            // Actualización de los campos
            actividadExisting.Titulo = txtTitulo.Text;
            actividadExisting.FechaPublicacion = DateTime.Parse(txtPublicacion.Text);
            actividadExisting.FechaCierre = DateTime.Parse(txtCierre.Text);

            resltado = ActividadService.ActualizarActividad(actividadExisting);


            lblMensaje.ForeColor = System.Drawing.Color.Green;
            lblMensaje.Text = resltado;

        }


    }



}