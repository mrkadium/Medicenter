using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Contacto
    {
        String _IDContacto;
        String __Para;
        String _IDPropietario;
        String _Tipo;
        String _Contacto;

        public string IDContacto { get => _IDContacto; set => _IDContacto = value; }
        public string Para { get => __Para; set => __Para = value; }
        public string IDPropietario { get => _IDPropietario; set => _IDPropietario = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string NombreContacto { get => _Contacto; set => _Contacto = value; }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();                        
            Sentencia.Append("INSERT INTO contactos(para, idpropietario, tipo, contacto) VALUES(");
            Sentencia.Append("'" + __Para + "',");
            Sentencia.Append(_IDPropietario + ",");
            Sentencia.Append("'" + _Tipo + "',");
            Sentencia.Append("'" + _Contacto + "');");
            
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

        public Boolean Actualizar()
        {

            Boolean Actualizado = false;
            StringBuilder Sentencia = new StringBuilder();                        
            Sentencia.Append("UPDATE contactos SET ");
            Sentencia.Append("para = '" + __Para + "',");
            Sentencia.Append("idpropietario = " + _IDPropietario  + ",");
            Sentencia.Append("tipo = '" + _Tipo + "',");
            Sentencia.Append("contacto = '" + _Contacto + "'");
            Sentencia.Append(" WHERE idcontacto = " + _IDContacto + ";");
            
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
            Sentencia.Append("DELETE FROM contactos WHERE idcontacto = " + _IDContacto + ";");

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
                Eliminado = false;
            }

            return Eliminado;
        }
    }
}
