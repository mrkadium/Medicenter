using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Examen
    {
        int _ID;
        String _Estado;
        String _Resultados;

        public int ID { get => _ID; set => _ID = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Resultados { get => _Resultados; set => _Resultados = value; }


        public Boolean Actualizar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("UPDATE resultados_examenes SET ");
            Sentencia.Append("resultados = '" + _Resultados + "',");
            Sentencia.Append("fecha = NOW(),");
            Sentencia.Append("estado ='ANALIZADO' WHERE idresultado='" + _ID + "';");
            DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();
            try
            {
                if (oOperacion.Actualizar(Sentencia.ToString()) > 0)
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
    }
}
