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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("~/Pages/Login/Condominio.aspx");
            }
            else
            {
                var usuario = (Usuario)Session["Usuario"];

                Usuario infoUsuario = UsuarioService.getUsuario(usuario.Correo);

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
    }
}