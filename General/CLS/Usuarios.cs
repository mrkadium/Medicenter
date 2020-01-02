using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Usuarios
    {
        int _idusuario;
        String _usuario;
        String _credencial;
        int _idrol;
        String _estado;

        public int Idusuario { get => _idusuario; set => _idusuario = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Credencial { get => _credencial; set => _credencial = value; }
        public int Idrol { get => _idrol; set => _idrol = value; }
        public string Estado { get => _estado; set => _estado = value; }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(
                @"insert into usuarios(usuario, credencial, idrol, estado) values(
                '" + _usuario + @"', 
                sha2('" + _credencial + @"', 256),
                '" + _idrol + @"',
                '" + _estado + "');");

            DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();
            try
            {
                if (oOperacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Guardado = true;
                }
                else
                {
                    Guardado = false;
                }
            }
            catch
            {
                Guardado = false;
            }

            return Guardado;
        }

        public Boolean ActualizarConPass()
        {
            Boolean Actualizado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(
                @"UPDATE usuarios SET 
                usuario = '" + _usuario + @"',
                credencial = sha2('" + _credencial + @"', 256),
                idrol = '" + _idrol + @"',
                estado = '" + _estado + @"'
                 WHERE idusuario = " + _idusuario + ";");

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
                Actualizado = false;
            }

            return Actualizado;
        }

        public Boolean ActualizarSinPass()
        {
            Boolean Actualizado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(
                @"UPDATE usuarios SET 
                usuario = '" + _usuario + @"',
                idrol = '" + _idrol + @"',
                estado = '" + _estado + @"'
                 WHERE idusuario = " + _idusuario + ";");

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
                Actualizado = false;
            }

            return Actualizado;
        }

        public Boolean Eliminar()
        {
            Boolean Eliminado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("DELETE FROM usuarios WHERE idusuario = " + _idusuario + ";");

            DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();
            try
            {
                if (oOperacion.Eliminar(Sentencia.ToString()) > 0)
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
                Eliminado = false;
            }

            return Eliminado;
        }
    }
}
