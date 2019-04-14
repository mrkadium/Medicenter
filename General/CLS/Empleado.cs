using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Empleado
    {
        String _IDEmpleado;
        String _Nombres;
        String _Apellidos;
        String _FechaNacimiento;
        String _DUI;
        String _NIT;
        String _Telefono;
        String _Direccion;

        public string IDEmpleado { get => _IDEmpleado; set => _IDEmpleado = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string DUI { get => _DUI; set => _DUI = value; }
        public string NIT { get => _NIT; set => _NIT = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO empleados(nombres, apellidos, fecha_nacimiento, dui, nit, telefono, direccion) VALUES (");
            Sentencia.Append("'"+ _Nombres + "',");
            Sentencia.Append("'" + _Apellidos + "',");
            Sentencia.Append("'" + _FechaNacimiento + "',");
            Sentencia.Append("'" + _DUI + "',");
            Sentencia.Append("'" + _NIT + "',");
            Sentencia.Append("'" + _Telefono + "',");
            Sentencia.Append("'" + _Direccion + "'");
            Sentencia.Append(");");

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

            }

            return Guardado;
        }
        public Boolean Actualizar()
        {
            Boolean Actualizado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("UPDATE empleados SET ");
            Sentencia.Append("nombres = '" + _Nombres + "',");
            Sentencia.Append("apellidos = '" + _Apellidos + "',");
            Sentencia.Append("fecha_nacimiento = '" + _FechaNacimiento + "',");
            Sentencia.Append("dui = '" + _DUI + "',");
            Sentencia.Append("nit = '" + _NIT + "',");
            Sentencia.Append("telefono = '" + _Telefono + "',");
            Sentencia.Append("direccion = '" + _Direccion + "'");
            Sentencia.Append(" WHERE idEmpleado = '"+ _IDEmpleado +"';");

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
            Sentencia.Append("DELETE FROM empleados WHERE idEmpleado = '" + _IDEmpleado + "';");

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
