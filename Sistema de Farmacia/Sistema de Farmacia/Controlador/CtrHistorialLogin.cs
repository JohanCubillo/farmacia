using Sistema_de_Farmacia.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistema_de_Farmacia.Controlador
{
    public class CtrHistorialLogin
    {
        public List<HistorialLogin> listarHistorialLogin()
        {
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "SELECT * FROM Requisiciones.historialLogin;";
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            List<HistorialLogin> lista = new List<HistorialLogin>();

            while (dr.Read())
            {
                HistorialLogin historiallogin = new HistorialLogin();

                historiallogin.Loginid = int.Parse(dr["loginId"].ToString());
                historiallogin.Fechainicial = (dr["fechaInicial"].ToString());
                historiallogin.Horainicial = (dr["horaInicial"].ToString());
                historiallogin.Usuarioid = int.Parse(dr["usuarioId"].ToString());
                historiallogin.Fechafinal = (dr["fechaFinal"].ToString());
                historiallogin.Horafinal = (dr["horaFinal"].ToString());
                lista.Add(historiallogin);
            }
            aux.conectar();
            return lista;
        }
        public HistorialLogin consultarHistorialLogin(int id)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "select * from historialLogin where loginId=@id;";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("loginId", id));
            SqlDataReader dr = command.ExecuteReader();

            HistorialLogin historiallogin = new HistorialLogin();

            if (dr.Read())
            {
                historiallogin.Loginid = int.Parse(dr["loginId"].ToString());
                historiallogin.Fechainicial = (dr["fechaInicial"].ToString());
                historiallogin.Horainicial = (dr["horaInicial"].ToString());
                historiallogin.Usuarioid = int.Parse(dr["usuarioId"].ToString());
                historiallogin.Fechafinal = (dr["fechaFinal"].ToString());
                historiallogin.Horafinal = (dr["horaFinal"].ToString());
            }
            return historiallogin;
        }
        public  bool insertarHistorialLogin(HistorialLogin historiallogin)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "insert  into historialLogin(fechaInicial,horaInicial,usuarioId,fechaFinal,horaFinal) values(@fechaInicial,@horaInicial,@usuarioId,@fechaFinal,@horaFinal)";
            command.CommandType = System.Data.CommandType.Text;

            historiallogin.Fechainicial = DateTime.Parse(historiallogin.Fechainicial).ToString("yyyy-MM-dd");
            historiallogin.Fechafinal = DateTime.Parse(historiallogin.Fechafinal).ToString("yyyy-MM-dd");

            command.Parameters.Add(new SqlParameter("fechaInicial", historiallogin.Fechainicial));
            command.Parameters.Add(new SqlParameter("horaInicial", historiallogin.Horainicial));
            command.Parameters.Add(new SqlParameter("usuarioId", historiallogin.Usuarioid));
            command.Parameters.Add(new SqlParameter("fechaFinal", historiallogin.Fechafinal));
            command.Parameters.Add(new SqlParameter("horaFinal", historiallogin.Horafinal));

            //Para verificar la insercion correctamente
            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }
        public bool editarHistorialLogin(HistorialLogin historiallogin)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "update historialLogin set fechaInicial=@fechaInicial,horaInicial=@horaInicial,usuarioId=@usuarioId,fechaFinal=@fechaFinal,horaFinal=@horaFinal     where loginId=@id";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("loginId", historiallogin.Loginid));
            command.Parameters.Add(new SqlParameter("fechaInicial", historiallogin.Fechainicial));
            command.Parameters.Add(new SqlParameter("horaInicial", historiallogin.Horainicial));
            command.Parameters.Add(new SqlParameter("usuarioId", historiallogin.Usuarioid));
            command.Parameters.Add(new SqlParameter("fechaFinal", historiallogin.Fechafinal));
            command.Parameters.Add(new SqlParameter("horaFinal", historiallogin.Horafinal));
            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }
    }
}
