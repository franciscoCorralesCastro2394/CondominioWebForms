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
        protected void Page_Init(object sender, EventArgs e)
        {
            // Bind data early in the lifecycle so controls and event-validation entries
            // are created before postback/event handling.
            CargarTablas();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Obtiene el usuario loggeado para asignarlo como creador de la actividad
            String resultado = string.Empty;
            var usuarioLoggeado = (Usuario)Session["Usuario"];

            // Crea la actividad dependiendo del tipo seleccionado en el dropdown
            if (ddlTipoActividad.SelectedValue == "Reunion")
            {
                Reunion reunion = new Reunion
                {
                    Id = Guid.NewGuid().ToString(),
                    Titulo = txtTitulo.Text,
                    EsParaTodos = chkTodos.Checked,
                    FechaPublicacion = DateTime.Parse(txtFechaPublicacion.Text),
                    FechaCierre = DateTime.Parse(txtFechaCierre.Text),
                    FechaHoraReunion = DateTime.Parse(txtFechaReunion.Text),
                    DuracionEstimada = txtDuracion.Text,
                    Agenda = txtAgenda.Text,
                    UbicacionPresencial = txtUbicacionPresencial.Text,
                    EnlaceVirtual = txtEnlaceVirtual.Text,
                    Creador = usuarioLoggeado.Correo,
                    estado = true
                };

                resultado = ActividadService.AgregarActividad(reunion);
            }

            if (ddlTipoActividad.SelectedValue == "Social")
            {
                ActividadSocial actividad = new ActividadSocial
                {
                    Id = Guid.NewGuid().ToString(),
                    Titulo = txtTitulo.Text,
                    EsParaTodos = chkTodos.Checked,
                    FechaPublicacion = DateTime.Parse(txtFechaPublicacion.Text),
                    FechaCierre = DateTime.Parse(txtFechaCierre.Text),
                    FechaInicio = DateTime.Parse(txtFechaInicio.Text),
                    FechaFin = DateTime.Parse(txtFechaFin.Text),
                    Ubicacion = txtUbicacionSocial.Text,
                    Formato = ddlFormato.Text,
                    Instrucciones = txtInstrucciones.Text,
                    Creador = usuarioLoggeado.Correo,
                    estado = true

                };

                resultado = ActividadService.AgregarActividad(actividad);
            }

            if (ddlTipoActividad.SelectedValue == "Recordatorio")
            {
                Recordatorio recordatorio = new Recordatorio
                {
                    Id = Guid.NewGuid().ToString(),
                    Titulo = txtTitulo.Text,
                    EsParaTodos = chkTodos.Checked,
                    FechaPublicacion = DateTime.Parse(txtFechaPublicacion.Text),
                    FechaCierre = DateTime.Parse(txtFechaCierre.Text),
                    Descripcion = txtDescripcionRecordatorio.Text,
                    Creador = usuarioLoggeado.Correo,
                    estado = true
                };

                resultado = ActividadService.AgregarActividad(recordatorio);
            }

            // Muestra un mensaje dependiendo del resultado de la creación de la actividad
            if (resultado.Contains("Error"))
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblMensaje.ForeColor = System.Drawing.Color.Green;
            }

            lblMensaje.Text = resultado;

            Response.Redirect(Request.RawUrl);
            // Recraga las tablas despues de crear 
            CargarTablas();

        }


        private void CargarTablas()
        {
            // Obtiene la lista de actividades
            var lista = ActividadService.ListaActividades;


            //Lista las activiades que han sido creadas
            //por el usuario loggeado, que esten activas y
            //que no hayan pasado su fecha de cierre
            var activiadesUsuario = lista.Where(
                                                a => a.Creador == ((Usuario)Session["Usuario"]).Correo
                                                && a.estado == true && a.FechaCierre > DateTime.Now
                                                ).ToList();

            // Separa las actividades por tipo para mostrarlas en tablas diferentes
            var reuniones = activiadesUsuario.OfType<Reunion>().ToList();
            var sociales = activiadesUsuario.OfType<ActividadSocial>().ToList();
            var recordatorios = activiadesUsuario.OfType<Recordatorio>().ToList();

            gvReuniones.DataSource = reuniones;
            gvReuniones.DataBind();

            gvSociales.DataSource = sociales;
            gvSociales.DataBind();

            gvRecordatorios.DataSource = recordatorios;
            gvRecordatorios.DataBind();
        }


        protected void gvReuniones_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            AccionesActividad(e);
        }

        protected void gvActividad_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            AccionesActividad(e);
        }

        protected void gvRecordatorio_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            AccionesActividad(e);
        }

        protected void AccionesActividad(GridViewCommandEventArgs e) 
        {
            // Obtiene el id de la actividad a eliminar o editar
            string id = e.CommandArgument.ToString();

            if (e.CommandName == "Eliminar")
            {
                // Elimina la actividad y recarga las tablas
                ActividadService.EliminarActividad(id);
                CargarTablas();
            }

            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Pages/EditarActividad.aspx?id=" + id);
            }

            if (e.CommandName == "Detalles") 
            {
                Response.Redirect("~/Pages/Actividades/Detalles.aspx?id=" + id);
            }

        }


       
    }
}