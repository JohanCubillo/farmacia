using Sistema_de_Farmacia.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistema_de_Farmacia.Controlador
{
    public class CtrUsuario
    {
        public List<Usuario> listarUsuarios()
        {
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "SELECT * FROM Usuario";
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();

            List<Usuario> lista = new List<Usuario>();
            while (dr.Read())
            {
                Usuario usuario = new Usuario();
                usuario.UsuarioId = int.Parse(dr["usuarioId"].ToString());
                usuario.Cedula = dr["cedula"].ToString();
                usuario.Nombre = dr["nombre"].ToString();
                usuario.Apellido = dr["apellido"].ToString();
                usuario.Telefono = dr["telefono"].ToString();
                usuario.Estado = dr["estado"].ToString();
                usuario.Mail = dr["mail"].ToString();
                usuario.Contrasena = dr["contrasena"].ToString().Trim();
                usuario.TipoUsuarioId = int.Parse(dr["tipoUsuarioId"].ToString());


                lista.Add(usuario);
            }
            aux.conectar();
            return lista;
        }
        public Usuario consultarUsuario(int id)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "select * from usuario where usuarioId=@id;";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("usuarioId", id));

            SqlDataReader dr = command.ExecuteReader();
            Usuario usuario = new Usuario();
            if (dr.Read())
            {

                Usuario Usuario = new Usuario();
                usuario.UsuarioId = int.Parse(dr["usuarioId"].ToString());
                usuario.Cedula = dr["cedula"].ToString();
                usuario.Nombre = dr["nombre"].ToString();
                usuario.Apellido = dr["apellido"].ToString();
                usuario.Telefono = dr["telefono"].ToString();
                usuario.Estado = dr["estado"].ToString();
                usuario.Mail = dr["mail"].ToString();
                usuario.Contrasena = dr["contrasena"].ToString();
                usuario.TipoUsuarioId = int.Parse(dr["tipoUsuarioId"].ToString());
            }
            return usuario;
        }
        public static bool insertarUsuario(Usuario usuario)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "insert  into usuario(cedula,nombre,apellido,telefono,estado,mail,contrasena,tipoUsuarioId) values(@cedula,@nombre,@apellido,@telefono,@estado,@mail,@contrasena,@tipoUsuarioId)";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("cedula", usuario.Cedula));
            command.Parameters.Add(new SqlParameter("nombre", usuario.Nombre));
            command.Parameters.Add(new SqlParameter("apellido", usuario.Apellido));
            command.Parameters.Add(new SqlParameter("telefono", usuario.Telefono));
            command.Parameters.Add(new SqlParameter("estado", usuario.Estado));
            command.Parameters.Add(new SqlParameter("mail", usuario.Mail));
            command.Parameters.Add(new SqlParameter("contrasena", usuario.Contrasena));
            command.Parameters.Add(new SqlParameter("tipoUsuarioId", usuario.TipoUsuarioId));


            //Para verificar la insercion correctamente
            int rs = command.ExecuteNonQuery();
            conexion.conectar();

            return rs >= 0;
        }
        public bool editarUsuario(Usuario usuario)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "update usuario set cedula=@cedula,nombre=@nombre,apellido=@apellido,telefono=@telefono,estado=@estado,mail=@mail,contrasena=@contrasena,tipoUsuarioId=@tipoUsuarioId where usuarioId=@id";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("usuarioId", usuario.UsuarioId));
            command.Parameters.Add(new SqlParameter("cedula", usuario.Cedula));
            command.Parameters.Add(new SqlParameter("nombre", usuario.Nombre));
            command.Parameters.Add(new SqlParameter("apellido", usuario.Apellido));
            command.Parameters.Add(new SqlParameter("telefono", usuario.Telefono));
            command.Parameters.Add(new SqlParameter("estado", usuario.Estado));
            command.Parameters.Add(new SqlParameter("mail", usuario.Mail));
            command.Parameters.Add(new SqlParameter("contrasena", usuario.Contrasena));
            command.Parameters.Add(new SqlParameter("tipoUsuarioId", usuario.TipoUsuarioId));
            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }
    }
}