using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Empleados
    {
        int _idempleado;
        String _nombres;
        String _apellidos;
        String _genero;
        DateTime _fechaNacimiento;
        String _dui;
        String _nit;
        String _municipio;
        String _direccion;
        int _idcargo;
        DateTime _fechaContratacion;
        DateTime _fechaSalida;
        String _estado;
        int _iddepartamento;
        String _fSalidaNula;
        String _fContratacionNula;

        public int Idempleado { get => _idempleado; set => _idempleado = value; }
        public string Nombres { get => _nombres; set => _nombres = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string Dui { get => _dui; set => _dui = value; }
        public string Nit { get => _nit; set => _nit = value; }
        public string Municipio { get => _municipio; set => _municipio = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public int Idcargo { get => _idcargo; set => _idcargo = value; }
        public DateTime FechaContratacion { get => _fechaContratacion; set => _fechaContratacion = value; }
        public DateTime FechaSalida { get => _fechaSalida; set => _fechaSalida = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public int Iddepartamento { get => _iddepartamento; set => _iddepartamento = value; }
        public string FSalidaNula { get => _fSalidaNula; set => _fSalidaNula = value; }
        public string FContratacionNula { get => _fContratacionNula; set => _fContratacionNula = value; }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            if (FContratacionNula == "null" && FSalidaNula != "null")
            {
                Sentencia.Append(
                    @"INSERT INTO empleados(nombres, apellidos, genero, 
                    fecha_nacimiento, dui, nit, municipio, direccion, idcargo, 
                    fechacontratacion, fechasalida, estado, iddepartamento) VALUES(
                    '" + _nombres + @"',
                    '" + _apellidos + @"',
                    '" + _genero + @"',
                    '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    '" + _dui + @"',
                    '" + _nit + @"',
                    '" + _municipio + @"',
                    '" + _direccion + @"',
                    '" + _idcargo + @"',
                    " + FContratacionNula + @",
                    '" + _fechaSalida.ToString("yyyy/MM/dd") + @"',
                    '" + _estado + "'," + _iddepartamento + ");");
            }
            else if (FSalidaNula == "null" && FContratacionNula != "null")
            {
                Sentencia.Append(
                    @"INSERT INTO empleados(nombres, apellidos, genero, 
                    fecha_nacimiento, dui, nit, municipio, direccion, idcargo, 
                    fechacontratacion, fechasalida, estado, iddepartamento) VALUES(
                    '" + _nombres + @"',
                    '" + _apellidos + @"',
                    '" + _genero + @"',
                    '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    '" + _dui + @"',
                    '" + _nit + @"',
                    '" + _municipio + @"',
                    '" + _direccion + @"',
                    '" + _idcargo + @"',
                    '" + _fechaContratacion.ToString("yyyy/MM/dd") + @"',
                    " + _fSalidaNula + @",
                    '" + _estado + "'," + _iddepartamento + ");");
            }
            else if (FContratacionNula == "null" && FSalidaNula == "null")
            {
                Sentencia.Append(
                    @"INSERT INTO empleados(nombres, apellidos, genero, 
                    fecha_nacimiento, dui, nit, municipio, direccion, idcargo, 
                    fechacontratacion, fechasalida, estado, iddepartamento) VALUES(
                    '" + _nombres + @"',
                    '" + _apellidos + @"',
                    '" + _genero + @"',
                    '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    '" + _dui + @"',
                    '" + _nit + @"',
                    '" + _municipio + @"',
                    '" + _direccion + @"',
                    '" + _idcargo + @"',
                    " + FContratacionNula + @",
                    " + _fSalidaNula + @",
                    '" + _estado + "'," + _iddepartamento + ");");
            }
            else
            {
                Sentencia.Append(
                    @"INSERT INTO empleados(nombres, apellidos, genero, 
                    fecha_nacimiento, dui, nit, municipio, direccion, idcargo, 
                    fechacontratacion, fechasalida, estado, iddepartamento) VALUES(
                    '" + _nombres + @"',
                    '" + _apellidos + @"',
                    '" + _genero + @"',
                    '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    '" + _dui + @"',
                    '" + _nit + @"',
                    '" + _municipio + @"',
                    '" + _direccion + @"',
                    '" + _idcargo + @"',
                    '" + _fechaContratacion.ToString("yyyy/MM/dd") + @"',
                    '" + _fechaSalida.ToString("yyyy/MM/dd") + @"',
                    '" + _estado + "'," + _iddepartamento + ");");
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

            if (FContratacionNula == "null" && FSalidaNula != "null")
            {
                Sentencia.Append(
                    @"UPDATE empleados SET 
                    nombres = '" + _nombres + @"',
                    apellidos = '" + _apellidos + @"',
                    genero = '" + _genero + @"',
                    fecha_nacimiento = '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    dui = '" + _dui + @"',
                    nit = '" + _nit + @"',
                    municipio = '" + _municipio + @"',
                    direccion = '" + _direccion + @"',
                    idcargo = '" + _idcargo + @"',
                    fechacontratacion = " + FContratacionNula + @",
                    fechasalida = '" + _fechaSalida.ToString("yyyy/MM/dd") + @"',
                    estado = '" + _estado + @"',
                    iddepartamento = '" + _iddepartamento + @"'
                     WHERE idempleado = " + _idempleado + ";");
            }
            else if (FSalidaNula == "null" && FContratacionNula != "null")
            {
                Sentencia.Append(
                    @"UPDATE empleados SET 
                    nombres = '" + _nombres + @"',
                    apellidos = '" + _apellidos + @"',
                    genero = '" + _genero + @"',
                    fecha_nacimiento = '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    dui = '" + _dui + @"',
                    nit = '" + _nit + @"',
                    municipio = '" + _municipio + @"',
                    direccion = '" + _direccion + @"',
                    idcargo = '" + _idcargo + @"',
                    fechacontratacion = '" + _fechaContratacion.ToString("yyyy/MM/dd") + @"',
                    fechasalida = " + _fSalidaNula + @",
                    estado = '" + _estado + @"',
                    iddepartamento = '" + _iddepartamento + @"'
                     WHERE idempleado = " + _idempleado + ";");
            }
            else if (FContratacionNula == "null" && FSalidaNula == "null")
            {
                Sentencia.Append(
                    @"UPDATE empleados SET 
                    nombres = '" + _nombres + @"',
                    apellidos = '" + _apellidos + @"',
                    genero = '" + _genero + @"',
                    fecha_nacimiento = '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    dui = '" + _dui + @"',
                    nit = '" + _nit + @"',
                    municipio = '" + _municipio + @"',
                    direccion = '" + _direccion + @"',
                    idcargo = '" + _idcargo + @"',
                    fechacontratacion = " + FContratacionNula + @",
                    fechasalida = " + _fSalidaNula + @",
                    estado = '" + _estado + @"',
                    iddepartamento = '" + _iddepartamento + @"'
                     WHERE idempleado = " + _idempleado + ";");
            }
            else
            {
                Sentencia.Append(
                    @"UPDATE empleados SET 
                    nombres = '" + _nombres + @"',
                    apellidos = '" + _apellidos + @"',
                    genero = '" + _genero + @"',
                    fecha_nacimiento = '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    dui = '" + _dui + @"',
                    nit = '" + _nit + @"',
                    municipio = '" + _municipio + @"',
                    direccion = '" + _direccion + @"',
                    idcargo = '" + _idcargo + @"',
                    fechacontratacion = '" + _fechaContratacion.ToString("yyyy/MM/dd") + @"',
                    fechasalida = '" + _fechaSalida.ToString("yyyy/MM/dd") + @"',
                    estado = '" + _estado + @"',
                    iddepartamento = '" + _iddepartamento + @"'
                     WHERE idempleado = " + _idempleado + ";");
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
            Sentencia.Append("DELETE FROM empleados WHERE idempleado = " + _idempleado + ";");

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
