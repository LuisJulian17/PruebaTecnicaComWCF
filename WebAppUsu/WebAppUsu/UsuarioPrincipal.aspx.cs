using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppUsu.ServiceUsu;

namespace WebAppUsu
{
    public partial class UsuarioPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Trim() != "" && txtfecha.Text.Trim() != "")
            {
                myUsuarioIServiceClient usu = new myUsuarioIServiceClient();
                Usuario usuario = new Usuario();
                usuario.Nom = txtNombre.Text;
                usuario.FechaN = txtfecha.Text;
                usuario.Sexo = DropSexo.Text;
                if (usu.NuevoUsuario(usuario) > 0)
                {
                    lblMensaje.Text = "Usuario agregado con exito";
                }

            }
            else
            {
                lblMensaje.Text = "Debe diligenciar todos los campos";
            }


        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("UsuarioConsulta.aspx");
        }
    }
}