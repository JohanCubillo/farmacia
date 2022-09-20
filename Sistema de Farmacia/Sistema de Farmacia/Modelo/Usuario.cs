using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_Farmacia.Modelo
{
    public class Usuario
    {
        private int _UsuarioId;
        private string _Cedula;
        private string _Nombre;
        private string _Apellido;
        private string _Telefono;
        private string _Estado;
        private string _Mail;
        private string _Contrasena;
        private int _TipoUsuarioId;

        public int UsuarioId { get => _UsuarioId; set => _UsuarioId = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Mail { get => _Mail; set => _Mail = value; }
        public string Contrasena { get => _Contrasena; set => _Contrasena = value; }
        public int TipoUsuarioId { get => _TipoUsuarioId; set => _TipoUsuarioId = value; }
    }

}