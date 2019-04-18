using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Usuario
    {
        String _IDUsuario;
        String _Usuario;
        String _Credencial;
        String _IDEmpleado;
        String _IDRol;
        String _Estado;
        String _Tipo;

        public string IDUsuario { get => _IDUsuario; set => _IDUsuario = value; }
        public string uUsuario { get => _Usuario; set => _Usuario = value; }
        public string Credencial { get => _Credencial; set => _Credencial = value; }
        public string IDEmpleado { get => _IDEmpleado; set => _IDEmpleado = value; }
        public string IDRol { get => _IDRol; set => _IDRol = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO usuarios(usuario, credencial, idempleado, idrol, estado) VALUES (");
            Sentencia.Append("'" + _Usuario + "',");
            Sentencia.Append("sha1('" + _Credencial + "'),");
            //Sentencia.Append("'" + _IDEmpleado + "',");
            Sentencia.Append("'" + _IDRol + "',");
            Sentencia.Append("'" + _Estado + "'");
            Sentencia.Append(");");

            DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();
            try
            {
                if (oOperacion.Insertar(Sentencia.ToString()) > 0)
                {
                    DataTable datosUsuario = CacheManager.SystemCache.getUsuario(_Usuario, _Credencial, _IDRol, _Estado);
                    String idusuario = datosUsuario.Rows[0].Field<String>("idusuario");

                    if (_Tipo.Equals("MEDICO"))
                    {
                        oOperacion.Insertar("INSERT INTO usuarios_medicos(idusuario, jvpm_medico) VALUES ('"+idusuario+"', '"+_IDEmpleado+"');");
                    }
                    else
                    {
                        oOperacion.Insertar("INSERT INTO usuarios_empleados(idusuario, idempleado) VALUES ('" + idusuario + "', '" + _IDEmpleado + "');");
                    }

                    Guardado = true;
                }
                else
                {
                    Guardado = false;
                }
            }
            catch
            {

            }

            return Guardado;
        }
        public Boolean Actualizar()
        {
            Boolean Actualizado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("UPDATE usuarios SET ");
            Sentencia.Append("usuario = '" + _Usuario + "',");
            Sentencia.Append("credencial = sha1('" + _Credencial + "'),");
            Sentencia.Append("idEmpleado = '" + _IDEmpleado + "',");
            Sentencia.Append("idRol = '" + _IDRol + "',");
            Sentencia.Append("estado = '" + _Estado + "'");
            Sentencia.Append(" WHERE idUsuario = '" + _IDUsuario + "';");

            DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();
            try
            {
                if (oOperacion.Actualizar(Sentencia.ToString()) > 0)
                {
                    Actualizado = true;
                }
                else
                {
                    Actualizado = false;
                }
            }
            catch
            {

            }

            return Actualizado;
        }
        public Boolean Eliminar()
        {
            Boolean Eliminado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("DELETE FROM usuarios WHERE idUsuario = '" + _IDUsuario + "';");

            DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();
            try
            {
                if (oOperacion.Actualizar(Sentencia.ToString()) > 0)
                {
                    Eliminado = true;
                }
                else
                {
                    Eliminado = false;
                }
            }
            catch
            {

            }

            return Eliminado;
        }
    }
}
