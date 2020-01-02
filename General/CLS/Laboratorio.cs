using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Laboratorio
    {
        int _ID;
        String _Nombre;
        String _Descripcion;
        String _Departamento;
        String _Municipio;

        public int ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Departamento { get => _Departamento; set => _Departamento = value; }
        public string Municipio { get => _Municipio; set => _Municipio = value; }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO laboratorios (nombre, iddepartamento, municipio, descripcion) VALUES (");
            Sentencia.Append("'" + _Nombre + "',");
            Sentencia.Append("'" + _Departamento + "',");
            Sentencia.Append("'" + _Municipio + "',");
            Sentencia.Append("'" + _Descripcion + "');");

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
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("UPDATE consumibles SET ");
            Sentencia.Append("nombre ='" + _Nombre + "',");
            Sentencia.Append("iddepartamento ='" + _Departamento + "',");
            Sentencia.Append("municipio ='" + _Municipio + "',");
            Sentencia.Append("descripcion ='" + _Descripcion + "' WHERE idlaboratorio ='" + _ID + "';");
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

        public Boolean Eliminar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("DELETE FROM laboratorios ");
            Sentencia.Append("WHERE idlaboratorio='" + _ID + "';");
            DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();
            try
            {
                if (oOperacion.Eliminar(Sentencia.ToString()) > 0)
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
