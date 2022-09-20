using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sistema_de_Farmacia.Modelo;
using Sistema_de_Farmacia.Controlador;

namespace Sistema_de_Farmacia
{
    public partial class Administracion_1 : System.Web.UI.Page
    {
        UsuarioSinglenton obj = UsuarioSinglenton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
           
          
                UsuarioSinglenton obj = UsuarioSinglenton.GetInstance();
                if (obj.usuario == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    if (obj.usuario.TipoUsuarioId != 1)
                    {
                        Response.Redirect(obj.rutas[obj.usuario.TipoUsuarioId - 1]);
                    }
                }
                this.lblNombre.Text = obj.usuario.Nombre + " " + obj.usuario.Apellido;

            }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administrador.aspx");
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            int TU;
            string E;
            TU = 1;
            E = "Inactivo";
            if (ListBoxTU.SelectedIndex == 0)
            {
                TU = 2;
            }
            else if (ListBoxTU.SelectedIndex == 1)
            {
                TU = 3;
            }
            else if (ListBoxTU.SelectedIndex == 2)
            {
                TU = 4;
            }
            else if (ListBoxTU.SelectedIndex == 3)
            {
                TU = 5;
            }
            else if (ListBoxTU.SelectedIndex == 4)
            {
                TU = 6;
            };



            if (ListBoxE.SelectedIndex == 0)
            {
                E = "Inactivo";
            }
            else if (ListBoxE.SelectedIndex == 1)
            {
                E = "Activo";
            };



            try
            {
                Usuario usuario = new Usuario();
                usuario.Cedula = txtId.Text;
                usuario.Nombre = txtNombres.Text;
                usuario.Apellido = txtApellidos.Text;
                usuario.Telefono = txtTelefono.Text;
                usuario.Mail = txtEmail.Text;
                usuario.Estado = E;
                usuario.TipoUsuarioId = TU;
                usuario.Contrasena = Encrypt.GetSHA256(this.txtContrasena.Text);


                CtrUsuario.insertarUsuario(usuario);
                //solucionar mensaje
               // MessageBox.Show("El usuario ha sido creado", "Crear usuario", MessageBoxButtons.OK);

            }
            catch (Exception)
            {
               // MessageBox.Show("El usuario no se ha creado", "Crear usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string fechaInicio = Session["fechaInicio"].ToString();
            string fechaFin = DateTime.Now.ToString();
            CtrHistorialLogin ctr = new CtrHistorialLogin();
            HistorialLogin login = new HistorialLogin();
            string[] inicio = fechaInicio.Split(' ');
            string[] fin = fechaFin.Split(' ');
            login.Fechainicial = inicio[0];
            login.Horainicial = inicio[1];
            login.Fechafinal = fin[0];
            login.Horafinal = fin[1];
            login.Usuarioid = obj.usuario.UsuarioId;
            ctr.insertarHistorialLogin(login);
            obj.usuario = null;
            Response.Redirect("Login.aspx");
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtTelefono.Text = "";
            txtApellidos.Text = "";
            txtEmail.Text = "";
            txtId.Text = "";
        }
    }
}