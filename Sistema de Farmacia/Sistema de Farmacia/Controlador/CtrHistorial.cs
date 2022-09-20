using Sistema_de_Farmacia.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistema_de_Farmacia.Controlador
{
    public class CtrHistorial
    {
        public List<Historial> listarHistorial()
        {
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "SELECT * FROM Requisiciones.Historial;";
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Historial> lista = new List<Historial>();

            while (dr.Read())
            {
                Historial historial = new Historial();
                historial.Historialid = int.Parse(dr["historialId"].ToString());
                historial.Usuarioid = int.Parse(dr["usuarioId"].ToString());
                historial.Fecha = DateTime.Parse(dr["fecha"].ToString());
                historial.Tipomovimientoid = int.Parse(dr["tipoMovimientoId"].ToString());
                historial.Solicitud = int.Parse(dr["solicitudId"].ToString());
                lista.Add(historial);
            }

            aux.conectar();
            return lista;
        }

        public Historial consultarHistorial(int id)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "select * from Historial where historialId=@id;";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("historialId", id));
            SqlDataReader dr = command.ExecuteReader();

            Historial historial = new Historial();
            if (dr.Read())
            {

                historial.Historialid = int.Parse(dr["historialId"].ToString());
                historial.Usuarioid = int.Parse(dr["usuarioId"].ToString());
                historial.Fecha = DateTime.Parse(dr["fecha"].ToString());
                historial.Tipomovimientoid = int.Parse(dr["tipoMovimientoId"].ToString());
                historial.Solicitud = int.Parse(dr["solicitudid"].ToString());

            }
            conexion.conectar();
            return historial;
        }
        public static bool insertarHistorial(Historial historial)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "insert  into Historial(usuarioId,fecha,tipoMovimientoId,solicitudId) values(@usuarioId,@fecha,@tipoMovimientoId,@solicitudId)";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("usuarioId", historial.Usuarioid));
            command.Parameters.Add(new SqlParameter("fecha", historial.Fecha));
            command.Parameters.Add(new SqlParameter("tipoMovimientoId", historial.Tipomovimientoid));
            command.Parameters.Add(new SqlParameter("solicitudId", historial.Solicitud));

            //Para verificar la insercion correctamente
            int rs = command.ExecuteNonQuery();
            conexion.conectar();


            return rs >= 0;
        }
        public bool editarHistorial(Historial historial)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "update Historial set usuarioId=@usuarioId,fecha=@fecha,tipoMovimientoId=@tipoMovimientoId,solicitudId=@solicitudId     where historialId=@id";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("historialId", historial.Historialid));
            command.Parameters.Add(new SqlParameter("usuarioId", historial.Usuarioid));
            command.Parameters.Add(new SqlParameter("fecha", historial.Fecha));
            command.Parameters.Add(new SqlParameter("tipoMovimientoId", historial.Tipomovimientoid));
            command.Parameters.Add(new SqlParameter("solicitudId", historial.Solicitud));

            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }

    }
}
    