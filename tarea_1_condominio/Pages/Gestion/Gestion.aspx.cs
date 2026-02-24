using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tarea_1_condominio.Models;
using tarea_1_condominio.Services;

namespace tarea_1_condominio.Pages.Gestion
{
    public partial class Gestion : System.Web.UI.Page
    {

        protected void Page_Init(object sender, EventArgs e)
        {
            // Verifica si el usuario ha iniciado sesión
            var usuario = (Usuario)Session["Usuario"];

            Usuario infoUsuario = UsuarioService.getUsuario(usuario.Correo);

            // Verifica si el usuario no ha iniciado sesión, redirige a la página de inicio de sesión
            if (Session["Usuario"] == null)
            {
                Response.Redirect("~/Pages/Login/Condominio.aspx");
                return;
            }

            // Si el usuario tiene el rol de Condominio, muestra la sección de actividades del condominio
            if (UsuarioService.ValidarRolCondominio(infoUsuario.Correo))
            {
                actividadesCondominio.Visible = true;
                cargarTableActividade();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var usuario = (Usuario)Session["Usuario"];

            Usuario infoUsuario = UsuarioService.getUsuario(usuario.Correo);


            //if (UsuarioService.ValidarRolCondominio(infoUsuario.Correo))
            //{
            //    actividadesCondominio.Visible = true;
            //    cargarTableActividade();
            //}

            if (usuario == null)
            {
                Response.Redirect("~/Pages/Login/Condominio.aspx");
            }
            else
            {
                
                lblMensaje.Text = "Bienvenido " + infoUsuario.Nombre + " " + infoUsuario.Apellidos;

                lblTipoId.Text = infoUsuario.TipoId;
                lblIdentificacion.Text = infoUsuario.Identificacion;
                lblNombre.Text = infoUsuario.Nombre;
                lblApellidos.Text = infoUsuario.Apellidos;
                lblFechaNacimiento.Text = infoUsuario.FechaNacimiento.ToShortDateString();
                lblFilial.Text = infoUsuario.Filial;
                lblConstruccion.Text = infoUsuario.TieneConstruccion ? "Sí" : "No";
                lblCorreo.Text = infoUsuario.Correo;

                if (UsuarioService.ValidarRol(infoUsuario.Correo))
                {
                    divActividades.Visible = true;
                }
            }

        }


        protected void btnCerrarSesion_Click(object sender, EventArgs e) 
        {
        
        }


        protected void cargarTableActividade() {

            // Obtiene la lista de actividades
            var lista = ActividadService.ListaActividades;


            //Lista las activiades que han sido creadas
            //por el usuario loggeado, que esten activas y
            //que no hayan pasado su fecha de cierre
            var activiadesUsuario = lista.Where(
                                                a => a.Creador == ((Usuario)Session["Usuario"]).Correo
                                                && a.estado == true && a.FechaCierre > DateTime.Now
                                                ).ToList();

            gvActividadesCondominio.DataSource = activiadesUsuario;
            gvActividadesCondominio.DataBind();
        }

        protected void gvActividadesCondominio_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Obtiene el ID de la actividad desde el CommandArgument
            string id = e.CommandArgument.ToString();
            if (e.CommandName == "DetallesActividad")
            {
                Response.Redirect("~/Pages/Actividades/Detalles.aspx?id=" + id);
            }
        }
    }
}