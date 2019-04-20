using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Medico
    {
        String _Idmedico;
        String _JVPM;
        String _Nombres;
        String _Apellidos;
        String _Genero;
        String _FechaNacimiento;
        String _Municipio;
        String _Direccion;
        String _DUI;
        String _NIT;
        String _FechaContratacion;
        String _FechaSalida;
        String _Estado;
        String _IDDepartamento;

        public string JVPM { get => _JVPM; set => _JVPM = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public string FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string Municipio { get => _Municipio; set => _Municipio = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string DUI { get => _DUI; set => _DUI = value; }
        public string NIT { get => _NIT; set => _NIT = value; }
        public string FechaContratacion { get => _FechaContratacion; set => _FechaContratacion = value; }
        public string FechaSalida { get => _FechaSalida; set => _FechaSalida = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string IDDepartamento { get => _IDDepartamento; set => _IDDepartamento = value; }
        public string Idmedico { get => _Idmedico; set => _Idmedico = value; }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            if(_FechaContratacion == "null" && _FechaSalida != "null")
            {
                Sentencia.Append("INSERT INTO medicos(jvpm, nombres, apellidos, genero, ");
                Sentencia.Append("fecha_nacimiento, municipio, direccion, ");
                Sentencia.Append("dui, nit, fechacontratacion, fechasalida, ");
                Sentencia.Append("estado, iddepartamento) VALUES(");
                Sentencia.Append("'" + _JVPM + "',");
                Sentencia.Append("'" + _Nombres + "',");
                Sentencia.Append("'" + _Apellidos + "',");
                Sentencia.Append("'" + _Genero + "',");
                Sentencia.Append("'" + _FechaNacimiento + "',");
                Sentencia.Append("'" + _Municipio + "',");
                Sentencia.Append("'" + _Direccion + "',");
                Sentencia.Append("'" + _DUI + "',");
                Sentencia.Append("'" + _NIT + "',");
                Sentencia.Append(_FechaContratacion + ",");
                Sentencia.Append("'" + _FechaSalida + "',");
                Sentencia.Append("'" + _Estado + "'," + _IDDepartamento + ");");
            }
            else if(_FechaSalida == "null" && _FechaContratacion != "null")
            {
                Sentencia.Append("INSERT INTO medicos(jvpm, nombres, apellidos, genero, ");
                Sentencia.Append("fecha_nacimiento, municipio, direccion, ");
                Sentencia.Append("dui, nit, fechacontratacion, fechasalida, ");
                Sentencia.Append("estado, iddepartamento) VALUES(");
                Sentencia.Append("'" + _JVPM + "',");
                Sentencia.Append("'" + _Nombres + "',");
                Sentencia.Append("'" + _Apellidos + "',");
                Sentencia.Append("'" + _Genero + "',");
                Sentencia.Append("'" + _FechaNacimiento + "',");
                Sentencia.Append("'" + _Municipio + "',");
                Sentencia.Append("'" + _Direccion + "',");
                Sentencia.Append("'" + _DUI + "',");
                Sentencia.Append("'" + _NIT + "',");
                Sentencia.Append("'" + _FechaContratacion + "',");
                Sentencia.Append(_FechaSalida + ",");
                Sentencia.Append("'" + _Estado + "'," + _IDDepartamento + ");");
            }
            else if (_FechaContratacion == "null" && _FechaSalida == "null")
            {
                Sentencia.Append("INSERT INTO medicos(jvpm, nombres, apellidos, genero, ");
                Sentencia.Append("fecha_nacimiento, municipio, direccion, ");
                Sentencia.Append("dui, nit, fechacontratacion, fechasalida, ");
                Sentencia.Append("estado, iddepartamento) VALUES(");
                Sentencia.Append("'" + _JVPM + "',");
                Sentencia.Append("'" + _Nombres + "',");
                Sentencia.Append("'" + _Apellidos + "',");
                Sentencia.Append("'" + _Genero + "',");
                Sentencia.Append("'" + _FechaNacimiento + "',");
                Sentencia.Append("'" + _Municipio + "',");
                Sentencia.Append("'" + _Direccion + "',");
                Sentencia.Append("'" + _DUI + "',");
                Sentencia.Append("'" + _NIT + "',");
                Sentencia.Append(_FechaContratacion + ",");
                Sentencia.Append(_FechaSalida + ",");
                Sentencia.Append("'" + _Estado + "'," + _IDDepartamento + ");");
            }
            else
            {
                Sentencia.Append("INSERT INTO medicos(jvpm, nombres, apellidos, genero, ");
                Sentencia.Append("fecha_nacimiento, municipio, direccion, ");
                Sentencia.Append("dui, nit, fechacontratacion, fechasalida, ");
                Sentencia.Append("estado, iddepartamento) VALUES(");
                Sentencia.Append("'" + _JVPM + "',");
                Sentencia.Append("'" + _Nombres + "',");
                Sentencia.Append("'" + _Apellidos + "',");
                Sentencia.Append("'" + _Genero + "',");
                Sentencia.Append("'" + _FechaNacimiento + "',");
                Sentencia.Append("'" + _Municipio + "',");
                Sentencia.Append("'" + _Direccion + "',");
                Sentencia.Append("'" + _DUI + "',");
                Sentencia.Append("'" + _NIT + "',");
                Sentencia.Append("'" + _FechaContratacion + "',");
                Sentencia.Append("'" + _FechaSalida + "',");
                Sentencia.Append("'" + _Estado + "'," + _IDDepartamento + ");");
            }
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

            if (_FechaContratacion == "null" && _FechaSalida != "null")
            {
                Sentencia.Append("UPDATE medicos SET ");
                Sentencia.Append("nombres = '" + _Nombres + "',");
                Sentencia.Append("apellidos = '" + _Apellidos + "',");
                Sentencia.Append("genero = '" + _Genero + "',");
                Sentencia.Append("fecha_nacimiento = '" + _FechaNacimiento + "',");
                Sentencia.Append("municipio = '" + _Municipio + "',");
                Sentencia.Append("direccion = '" + _Direccion + "',");
                Sentencia.Append("dui = '" + _DUI + "',");
                Sentencia.Append("nit = '" + _NIT + "',");
                Sentencia.Append("fechacontratacion = " + _FechaContratacion + ",");
                Sentencia.Append("fechasalida = '" + _FechaSalida + "',");
                Sentencia.Append("estado = '" + _Estado + "',");
                Sentencia.Append("iddepartamento = '" + _IDDepartamento + "'");
                Sentencia.Append(" WHERE idmedico = " + _Idmedico + ";");
            }
            else if (_FechaSalida == "null" && _FechaContratacion != "null")
            {
                Sentencia.Append("UPDATE medicos SET ");
                Sentencia.Append("nombres = '" + _Nombres + "',");
                Sentencia.Append("apellidos = '" + _Apellidos + "',");
                Sentencia.Append("genero = '" + _Genero + "',");
                Sentencia.Append("fecha_nacimiento = '" + _FechaNacimiento + "',");
                Sentencia.Append("municipio = '" + _Municipio + "',");
                Sentencia.Append("direccion = '" + _Direccion + "',");
                Sentencia.Append("dui = '" + _DUI + "',");
                Sentencia.Append("nit = '" + _NIT + "',");
                Sentencia.Append("fechacontratacion = '" + _FechaContratacion + "',");
                Sentencia.Append("fechasalida = " + _FechaSalida + ",");
                Sentencia.Append("estado = '" + _Estado + "',");
                Sentencia.Append("iddepartamento = '" + _IDDepartamento + "'");
                Sentencia.Append(" WHERE idmedico = " + _Idmedico + ";");
            }
            else if (_FechaContratacion == "null" && _FechaSalida == "null")
            {
                Sentencia.Append("UPDATE medicos SET ");
                Sentencia.Append("nombres = '" + _Nombres + "',");
                Sentencia.Append("apellidos = '" + _Apellidos + "',");
                Sentencia.Append("genero = '" + _Genero + "',");
                Sentencia.Append("fecha_nacimiento = '" + _FechaNacimiento + "',");
                Sentencia.Append("municipio = '" + _Municipio + "',");
                Sentencia.Append("direccion = '" + _Direccion + "',");
                Sentencia.Append("dui = '" + _DUI + "',");
                Sentencia.Append("nit = '" + _NIT + "',");
                Sentencia.Append("fechacontratacion = " + _FechaContratacion + ",");
                Sentencia.Append("fechasalida = " + _FechaSalida + ",");
                Sentencia.Append("estado = '" + _Estado + "',");
                Sentencia.Append("iddepartamento = '" + _IDDepartamento + "'");
                Sentencia.Append(" WHERE idmedico = " + _Idmedico + ";");
            }
            else
            {
                Sentencia.Append("UPDATE medicos SET ");
                Sentencia.Append("nombres = '" + _Nombres + "',");
                Sentencia.Append("apellidos = '" + _Apellidos + "',");
                Sentencia.Append("genero = '" + _Genero + "',");
                Sentencia.Append("fecha_nacimiento = '" + _FechaNacimiento + "',");
                Sentencia.Append("municipio = '" + _Municipio + "',");
                Sentencia.Append("direccion = '" + _Direccion + "',");
                Sentencia.Append("dui = '" + _DUI + "',");
                Sentencia.Append("nit = '" + _NIT + "',");
                Sentencia.Append("fechacontratacion = '" + _FechaContratacion + "',");
                Sentencia.Append("fechasalida = '" + _FechaSalida + "',");
                Sentencia.Append("estado = '" + _Estado + "',");
                Sentencia.Append("iddepartamento = '" + _IDDepartamento + "'");
                Sentencia.Append(" WHERE idmedico = " + _Idmedico + ";");
            }

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
            Sentencia.Append("DELETE FROM medicos WHERE idmedico = " + _Idmedico + ";");

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
