using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class ContactosMedicos
    {
        int _idcontacto;
        int _idmedico;

        public int Idcontacto { get => _idcontacto; set => _idcontacto = value; }
        public int Idmedico { get => _idmedico; set => _idmedico = value; }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(
                @"insert into contactos_medico(idcontacto, idmedico) values(
                '" + _idcontacto + @"',
                '" + _idmedico + "');");

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
        
        public Boolean Eliminar()
        {
            Boolean Eliminado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(
                @"DELETE FROM contactos_medico WHERE idmedico = " + _idmedico + ";");

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

        public Boolean EliminarPorContacto()
        {
            Boolean Eliminado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(
                @"DELETE FROM contactos_medico WHERE idcontacto = " + _idcontacto + " and idmedico = " + _idmedico + ";");

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
