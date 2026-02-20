using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tarea_1_condominio.Models;
using tarea_1_condominio.Services;

namespace tarea_1_condominio.Pages.Registro
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            UsuarioService service = new UsuarioService();

            Usuario nuevo = new Usuario
            {
                TipoId = ddlTipoId.SelectedValue,
                Identificacion = txtIdentificacion.Text,
                Nombre = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text),
                Filial = txtFilial.Text,
                TieneConstruccion = chkConstruccion.Checked,
                Correo = txtCorreo.Text,
                Password = txtPassword.Text
            };

            string resultado = service.Registrar(nuevo);

            lblMensaje.ForeColor = System.Drawing.Color.Green;
            lblMensaje.Text = resultado;
        }

    }
}