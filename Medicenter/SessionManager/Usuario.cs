using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionManager
{
    public class Usuario
    {
        String _IDUsuario;
        String _Usuario;
        String _IDRol;
        String _IDEmpleado;
        String _Empleado;
        String _Rol;

        public string IDUsuario { get => _IDUsuario; set => _IDUsuario = value; }
        public string Usuario1 { get => _Usuario; set => _Usuario = value; }
        public string IDRol { get => _IDRol; set => _IDRol = value; }
        public string IDEmpleado { get => _IDEmpleado; set => _IDEmpleado = value; }
        public string Empleado { get => _Empleado; set => _Empleado = value; }
        public string Rol { get => _Rol; set => _Rol = value; }
    }
}
