using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tarea_1_condominio.Models;
using tarea_1_condominio.Services;

namespace tarea_1_condominio.Pages.Login
{
    public partial class Condominio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAuth_Click(object sender, EventArgs e)
        {
            Usuario usuarioAuth = new Usuario
            {
                Correo = CondCorreo.Text,
                Password = CondPassword.Text
            };

            // Call the static method directly on the static class
            string resultado = UsuarioService.Utenticar(usuarioAuth);

            if (resultado.Contains("Error")) 
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
            else 
            { 
                lblMensaje.ForeColor = System.Drawing.Color.Green;

                Session["Usuario"] = usuarioAuth;
                Response.Redirect("~/Pages/Gestion/Gestion.aspx");
            }

            lblMensaje.Text = resultado;


        }
    }
}