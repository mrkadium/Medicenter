using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SessionManager
{
    public class Usuario
    {
        DataTable _Permisos;

        String _IDUsuario;
        String _Usuario;
        String _IDRol;
        String _IDEmpleado;
        String _Empleado;
        String _Rol;
        List<String> _Opciones;

        public string IDUsuario { get => _IDUsuario; set => _IDUsuario = value; }
        public string Usuario1 { get => _Usuario; set => _Usuario = value; }
        public string IDRol { get => _IDRol; set => _IDRol = value; }
        public string IDEmpleado { get => _IDEmpleado; set => _IDEmpleado = value; }
        public string Empleado { get => _Empleado; set => _Empleado = value; }
        public string Rol { get => _Rol; set => _Rol = value; }
        public List<string> Opciones { get => _Opciones; set => _Opciones = value; }

        private void CargarPermisos()
        {
            _Permisos = CacheManager.SystemCache.PermisosUsuario(_Usuario);
        }

        public void ObtenerInfo()
        {
            CargarPermisos();
        }

        public Boolean VerificarPermiso(Int32 pIDPermiso)
        {
            Boolean Autorizado = false;

            foreach (DataRow Fila in _Permisos.Rows)
            {
                if (Fila["IDOpcion"].ToString().Equals(pIDPermiso.ToString()))
                {
                    Autorizado = true;
                    break;
                }
            }
            //Hay que usar el valor que devuelve desde donde se llama la función
            //if (Autorizado == false)
            //{
            //    MessageBox.Show("El usuario no cuenta con el permiso para realizar la acción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            return Autorizado;
        }

        public bool verificarPermiso(String opcion)
        {
            bool esta = false;
            for (int i = 0; i < _Opciones.Count; i++)
            {
                if (_Opciones[i].Equals(opcion))
                {
                    esta = true;
                }
            }
            return esta;
        }
    }
}
