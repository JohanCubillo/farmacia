using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_Farmacia.Modelo
{
    public class Historial
    {
        private int _Historialid;
        private int _Usuarioid;
        private DateTime _Fecha;
        private int _Tipomovimientoid;
        private int _Solicitudid;





        public int Historialid { get => _Historialid; set => _Historialid = value; }
        public int Usuarioid { get => _Usuarioid; set => _Usuarioid = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public int Tipomovimientoid { get => _Tipomovimientoid; set => _Tipomovimientoid = value; }
        public int Solicitud { get => _Solicitudid; set => _Solicitudid = value; }

    }
}
