using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_Farmacia.Modelo
{
    public class HistorialLogin
    {
        private int _Loginid;
        private String _Fechainicial;
        private String _Horainicial;
        private int _Usuarioid;
        private String _Fechafinal;
        private String _Horafinal;

        public int Loginid { get => _Loginid; set => _Loginid = value; }
        public String Fechainicial { get => _Fechainicial; set => _Fechainicial = value; }
        public String Horainicial { get => _Horainicial; set => _Horainicial = value; }
        public int Usuarioid { get => _Usuarioid; set => _Usuarioid = value; }
        public String Fechafinal { get => _Fechafinal; set => _Fechafinal = value; }
        public String Horafinal { get => _Horafinal; set => _Horafinal = value; }
    }
}