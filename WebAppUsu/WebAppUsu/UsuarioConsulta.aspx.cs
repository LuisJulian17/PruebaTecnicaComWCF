using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppUsu.ServiceUsu;


namespace WebAppUsu
{
    public partial class UsuarioConsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            myUsuarioIServiceClient usuario = new myUsuarioIServiceClient();
            gvDatos.DataSource = usuario.ListarUsuarios();
            gvDatos.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            myUsuarioIServiceClient usu = new myUsuarioIServiceClient();
            Usuario usuario = new Usuario();
            if (txtID.Text.Trim() != "")
            {
                usuario = usu.buscarUsuario(int.Parse(txtID.Text));
                txtNombre.Text = usuario.Nom;
                DropSexo.Text = usuario.Sexo;
                txtfecha.Text = usuario.FechaN;
            }
            else
            {
                lblMensaje.Text = "Escriba el ID del Usuario...";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "" && txtfecha.Text.Trim() != "")
            {
                myUsuarioIServiceClient usu = new myUsuarioIServiceClient();
                Usuario usuario = new Usuario();
                usuario.Id = int.Parse(txtID.Text);
                usuario.Nom = txtNombre.Text;
                usuario.FechaN = txtfecha.Text;
                usuario.Sexo = DropSexo.Text;
                if (usu.EditarUsuario(usuario) > 0)
                {
                    lblMensaje.Text = "Usuario Actualizado con exito";
                }
                else
                {
                    lblMensaje.Text = "El Usuario No Fue Actualizado";
                }
            }
            else
            {
                lblMensaje.Text = "Debe diligenciar todos los campos";
            }



        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            myUsuarioIServiceClient usu = new myUsuarioIServiceClient();
            if(txtID.Text.Trim() != "")
            {
                if (usu.EliminarUsuario(int.Parse(txtID.Text)) > 0)
                {
                    lblMensaje.Text = "Usuario Eliminado con exito";
                }
                else
                {
                    lblMensaje.Text = "Error al eliminar";
                }
            }
            else
            {
                lblMensaje.Text = "Debe diligenciar el campo ID";
            }

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            myUsuarioIServiceClient usuario = new myUsuarioIServiceClient();
            gvDatos.DataSource = usuario.ListarUsuarios();
            gvDatos.DataBind();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("UsuarioPrincipal.aspx");
        }
    }
}