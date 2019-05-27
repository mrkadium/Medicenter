using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Medicos
    {
        int _idmedico;
        int _jvpm;
        String _nombres;
        String _apellidos;
        String _genero;
        DateTime _fechaNacimiento;
        String _municipio;
        String _direccion;
        String _dui;
        String _nit;
        DateTime _fechaContratacion;
        DateTime _fechaSalida;
        String _estado;
        int _idDepartamento;
        String _fSalidaNula;
        String _fContratacionNula;

        public int Idmedico { get => _idmedico; set => _idmedico = value; }
        public int Jvpm { get => _jvpm; set => _jvpm = value; }
        public string Nombres { get => _nombres; set => _nombres = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string Municipio { get => _municipio; set => _municipio = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Dui { get => _dui; set => _dui = value; }
        public string Nit { get => _nit; set => _nit = value; }
        public DateTime FechaContratacion { get => _fechaContratacion; set => _fechaContratacion = value; }
        public DateTime FechaSalida { get => _fechaSalida; set => _fechaSalida = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public int IdDepartamento { get => _idDepartamento; set => _idDepartamento = value; }
        public string FSalidaNula { get => _fSalidaNula; set => _fSalidaNula = value; }
        public string FContratacionNula { get => _fContratacionNula; set => _fContratacionNula = value; }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            if (_fContratacionNula == "null" && _fSalidaNula != "null")
            {
                Sentencia.Append(
                    @"INSERT INTO medicos(jvpm, nombres, apellidos, genero, 
                    fecha_nacimiento, municipio, direccion, 
                    dui, nit, fechacontratacion, fechasalida, 
                    estado, iddepartamento) VALUES(
                    '" + _jvpm + @"',
                    '" + _nombres + @"',
                    '" + _apellidos + @"',
                    '" + _genero + @"',
                    '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    '" + _municipio + @"',
                    '" + _direccion + @"',
                    '" + _dui + @"',
                    '" + _nit + @"',
                    " + _fContratacionNula + @",
                    '" + _fechaSalida.ToString("yyyy/MM/dd") + @"',
                    '" + _estado + "'," + _idDepartamento + ");");
            }
            else if (_fSalidaNula == "null" && _fContratacionNula != "null")
            {
                Sentencia.Append(
                    @"INSERT INTO medicos(jvpm, nombres, apellidos, genero, 
                    fecha_nacimiento, municipio, direccion, 
                    dui, nit, fechacontratacion, fechasalida, 
                    estado, iddepartamento) VALUES(
                    '" + _jvpm + @"',
                    '" + _nombres + @"',
                    '" + _apellidos + @"',
                    '" + _genero + @"',
                    '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    '" + _municipio + @"',
                    '" + _direccion + @"',
                    '" + _dui + @"',
                    '" + _nit + @"',
                    '" + _fechaContratacion.ToString("yyyy/MM/dd") + @"',
                    " + _fSalidaNula + @",
                    '" + _estado + "'," + _idDepartamento + ");");
            }
            else if (_fContratacionNula == "null" && _fSalidaNula == "null")
            {
                Sentencia.Append(
                    @"INSERT INTO medicos(jvpm, nombres, apellidos, genero, 
                    fecha_nacimiento, municipio, direccion, 
                    dui, nit, fechacontratacion, fechasalida, 
                    estado, iddepartamento) VALUES(
                    '" + _jvpm + @"',
                    '" + _nombres + @"',
                    '" + _apellidos + @"',
                    '" + _genero + @"',
                    '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    '" + _municipio + @"',
                    '" + _direccion + @"',
                    '" + _dui + @"',
                    '" + _nit + @"',
                    " + _fContratacionNula + @",
                    " + _fSalidaNula + @",
                    '" + _estado + "'," + _idDepartamento + ");");
            }
            else
            {
                Sentencia.Append(
                    @"INSERT INTO medicos(jvpm, nombres, apellidos, genero, 
                    fecha_nacimiento, municipio, direccion, 
                    dui, nit, fechacontratacion, fechasalida, 
                    estado, iddepartamento) VALUES(
                    '" + _jvpm + @"',
                    '" + _nombres + @"',
                    '" + _apellidos + @"',
                    '" + _genero + @"',
                    '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    '" + _municipio + @"',
                    '" + _direccion + @"',
                    '" + _dui + @"',
                    '" + _nit + @"',
                    '" + _fechaContratacion.ToString("yyyy/MM/dd") + @"',
                    '" + _fechaSalida.ToString("yyyy/MM/dd") + @"',
                    '" + _estado + "'," + _idDepartamento + ");");
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

            if (_fContratacionNula == "null" && _fSalidaNula != "null")
            {
                Sentencia.Append(
                    @"UPDATE medicos SET 
                    jvpm = " + _jvpm + @",
                    nombres = '" + _nombres + @"',
                    apellidos = '" + _apellidos + @"',
                    genero = '" + _genero + @"',
                    fecha_nacimiento = '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    municipio = '" + _municipio + @"',
                    direccion = '" + _direccion + @"',
                    dui = '" + _dui + @"',
                    nit = '" + _nit + @"',
                    fechacontratacion = " + _fContratacionNula + @",
                    fechasalida = '" + _fechaSalida.ToString("yyyy/MM/dd") + @"',
                    estado = '" + _estado + @"',
                    iddepartamento = '" + _idDepartamento + @"'
                     WHERE idmedico = " + _idmedico + ";");
            }
            else if (_fSalidaNula == "null" && _fContratacionNula != "null")
            {
                Sentencia.Append(
                    @"UPDATE medicos SET 
                    jvpm = " + _jvpm + @",
                    nombres = '" + _nombres + @"',
                    apellidos = '" + _apellidos + @"',
                    genero = '" + _genero + @"',
                    fecha_nacimiento = '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    municipio = '" + _municipio + @"',
                    direccion = '" + _direccion + @"',
                    dui = '" + _dui + @"',
                    nit = '" + _nit + @"',
                    fechacontratacion = '" + _fechaContratacion.ToString("yyyy/MM/dd") + @"',
                    fechasalida = " + _fSalidaNula + @",
                    estado = '" + _estado + @"',
                    iddepartamento = '" + _idDepartamento + @"'
                     WHERE idmedico = " + _idmedico + ";");
            }
            else if (_fContratacionNula == "null" && _fSalidaNula == "null")
            {
                Sentencia.Append(
                    @"UPDATE medicos SET 
                    jvpm = " + _jvpm + @",
                    nombres = '" + _nombres + @"',
                    apellidos = '" + _apellidos + @"',
                    genero = '" + _genero + @"',
                    fecha_nacimiento = '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    municipio = '" + _municipio + @"',
                    direccion = '" + _direccion + @"',
                    dui = '" + _dui + @"',
                    nit = '" + _nit + @"',
                    fechacontratacion = " + _fContratacionNula + @",
                    fechasalida = " + _fSalidaNula + @",
                    estado = '" + _estado + @"',
                    iddepartamento = '" + _idDepartamento + @"'
                     WHERE idmedico = " + _idmedico + ";");
            }
            else
            {
                Sentencia.Append(
                    @"UPDATE medicos SET 
                    jvpm = " + _jvpm + @",
                    nombres = '" + _nombres + @"',
                    apellidos = '" + _apellidos + @"',
                    genero = '" + _genero + @"',
                    fecha_nacimiento = '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    municipio = '" + _municipio + @"',
                    direccion = '" + _direccion + @"',
                    dui = '" + _dui + @"',
                    nit = '" + _nit + @"',
                    fechacontratacion = '" + _fechaContratacion.ToString("yyyy/MM/dd") + @"',
                    fechasalida = '" + _fechaSalida.ToString("yyyy/MM/dd") + @"',
                    estado = '" + _estado + @"',
                    iddepartamento = '" + _idDepartamento + @"'
                     WHERE idmedico = " + _idmedico + ";");
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
            Sentencia.Append("DELETE FROM medicos WHERE idmedico = " + _idmedico + ";");

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
