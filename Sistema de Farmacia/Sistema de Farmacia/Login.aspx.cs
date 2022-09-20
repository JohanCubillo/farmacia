using Sistema_de_Farmacia.Controlador;
using Sistema_de_Farmacia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Farmacia
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["fechaInicio"] = DateTime.Now.ToString();
            // string pass = this.txtPass.Text;
            string pass = Encrypt.GetSHA256(this.txtPass.Text);
            string email = this.txtEmail.Text;

            CtrUsuario ctr = new CtrUsuario();
            List<Usuario> users = ctr.listarUsuarios();
            Usuario usuario = users.FirstOrDefault(u => u.Mail.Trim() == email && u.Contrasena == pass && u.Estado == "activo                                            ");

            if (usuario != null)
            {

                UsuarioSinglenton obj = UsuarioSinglenton.GetInstance();
                obj.usuario = usuario;
                Response.Redirect(obj.rutas[usuario.TipoUsuarioId - 1]);
            }
            else
            {
                // MessageBox.Show("Usuario / contraseña incorrectos o usuario inactivo", "Login", MessageBoxButtons.OK);
                mensajeError.Text = "Usuario o contraseña incorrectos";
                mensajeError.ForeColor = System.Drawing.Color.Red;

            }
        }
        public bool validar(string email, string e, string password, string p)
        {
            return (email == e) && (password == p);
        }
    
    

    protected void CBRecordarContraseña_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
