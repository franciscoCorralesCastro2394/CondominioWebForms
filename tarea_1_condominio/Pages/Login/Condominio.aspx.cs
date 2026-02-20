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
            UsuarioService service = new UsuarioService();

            Usuario nuevo = new Usuario
            {
                Correo = CondCorreo.Text,
                Password = CondPassword.Text

            };

            string resultado = service.Utenticar(nuevo);

            lblMensaje.ForeColor = System.Drawing.Color.Green;
            lblMensaje.Text = resultado;
        }
    }
}