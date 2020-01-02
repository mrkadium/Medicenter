using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Pacientes
    {
        int _idpaciente;
        int _expediente;
        String _nombres;
        String _apellidos;
        DateTime _fechaNacimiento;
        String _genero;
        String _telefono;
        String _email;
        String _municipio;
        int _iddepartamento;


        public int Idpaciente { get => _idpaciente; set => _idpaciente = value; }
        public int Expediente { get => _expediente; set => _expediente = value; }
        public string Nombres { get => _nombres; set => _nombres = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
        public string Municipio { get => _municipio; set => _municipio = value; }
        public int Iddepartamento { get => _iddepartamento; set => _iddepartamento = value; }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            if (_telefono == "null" && _email != "null")
            {
                Sentencia.Append(
                    @"insert into pacientes(expediente, nombres, apellidos, fecha_nacimiento, 
					genero, telefono, email, municipio, iddepartamento) values(
                    '" + _expediente + @"',
                    '" + _nombres + @"', 
                    '" + _apellidos + @"', 
                    '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"', 
                    '" + _genero + @"',
                    " + _telefono + @",
                    '" + _email + @"',
                    '" + _municipio + @"',
                    '" + _iddepartamento + "');");
            }
            else if (_email == "null" && _telefono != "null")
            {
                Sentencia.Append(
                    @"insert into pacientes(expediente, nombres, apellidos, fecha_nacimiento, 
					genero, telefono, email, municipio, iddepartamento) values(
                    '" + _expediente + @"',
                    '" + _nombres + @"', 
                    '" + _apellidos + @"', 
                    '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"', 
                    '" + _genero + @"',
                    '" + _telefono + @"',
                    " + _email + @",
                    '" + _municipio + @"',
                    '" + _iddepartamento + "');");
            }
            else if (_telefono == "null" && _email == "null")
            {
                Sentencia.Append(
                    @"insert into pacientes(expediente, nombres, apellidos, fecha_nacimiento, 
					genero, telefono, email, municipio, iddepartamento) values(
                    '" + _expediente + @"',
                    '" + _nombres + @"', 
                    '" + _apellidos + @"', 
                    '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"', 
                    '" + _genero + @"',
                    " + _telefono + @",
                    " + _email + @",
                    '" + _municipio + @"',
                    '" + _iddepartamento + "');");
            }
            else
            {
                Sentencia.Append(
                    @"insert into pacientes(expediente, nombres, apellidos, fecha_nacimiento, 
					genero, telefono, email, municipio, iddepartamento) values(
                    '" + _expediente + @"',
                    '" + _nombres + @"', 
                    '" + _apellidos + @"', 
                    '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"', 
                    '" + _genero + @"',
                    '" + _telefono + @"',
                    '" + _email + @"',
                    '" + _municipio + @"',
                    '" + _iddepartamento + "');");
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

            if (_telefono == "null" && _email != "null")
            {
                Sentencia.Append(
                    @"UPDATE pacientes SET 
                    expediente = '" + _expediente + @"',
                    nombres = '" + _nombres + @"',
                    apellidos = '" + _apellidos + @"',
                    fecha_nacimiento = '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                    genero = '" + _genero + @"',
                    telefono = " + _telefono + @",
                    email = '" + _email + @"',
                    municipio = '" + _municipio + @"',
                    iddepartamento = '" + _iddepartamento + @"'
                    WHERE idpaciente = " + _idpaciente + ";");
            }
            else if (_email == "null" && _telefono != "null")
            {
                Sentencia.Append(
                    @"UPDATE pacientes SET 
                expediente = '" + _expediente + @"',
                nombres = '" + _nombres + @"',
                apellidos = '" + _apellidos + @"',
                fecha_nacimiento = '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                genero = '" + _genero + @"',
                telefono = '" + _telefono + @"',
                email = " + _email + @",
                municipio = '" + _municipio + @"',
                iddepartamento = '" + _iddepartamento + @"'
                WHERE idpaciente = " + _idpaciente + ";");
            }
            else if (_telefono == "null" && _email == "null")
            {
                Sentencia.Append(
                    @"UPDATE pacientes SET 
                expediente = '" + _expediente + @"',
                nombres = '" + _nombres + @"',
                apellidos = '" + _apellidos + @"',
                fecha_nacimiento = '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"'
                genero = '" + _genero + @"',
                telefono = " + _telefono + @",
                email = " + _email + @",
                municipio = '" + _municipio + @"',
                iddepartamento = '" + _iddepartamento + @"'
                WHERE idpaciente = " + _idpaciente + ";");
            }
            else
            {
                Sentencia.Append(
                    @"UPDATE pacientes SET 
                expediente = '" + _expediente + @"',
                nombres = '" + _nombres + @"',
                apellidos = '" + _apellidos + @"',
                fecha_nacimiento = '" + _fechaNacimiento.ToString("yyyy/MM/dd") + @"',
                genero = '" + _genero + @"',
                telefono = '" + _telefono + @"',
                email = '" + _email + @"',
                municipio = '" + _municipio + @"',
                iddepartamento = '" + _iddepartamento + @"'
                WHERE idpaciente = " + _idpaciente + ";");
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
            Sentencia.Append("DELETE FROM pacientes WHERE idpaciente = " + _idpaciente + ";");

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
