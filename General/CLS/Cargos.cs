using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Cargos
    {
        int _idcargo;
        String _cargo;

        public int Idcargo { get => _idcargo; set => _idcargo = value; }
        public string Cargo { get => _cargo; set => _cargo = value; }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append(
                @"insert into cargos(cargo) values(
                '" + _cargo + @"');");

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
            Sentencia.Append(
                @"UPDATE cargos SET 
                cargo = '" + _cargo + @"'
                WHERE idcargo = " + _idcargo + ";");

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
            Sentencia.Append("DELETE FROM cargos WHERE idcargo = " + _idcargo + ";");

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

