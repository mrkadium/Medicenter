using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManager
{
    public static class SystemCache
    {
        public static DataTable ValidarUsuario(String pUsuario, String pClave)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT
	                a.idusuario,
                    a.usuario,
                    a.idrol, b.rol,
                    c.idempleado,
                    concat(c.nombres, ' ', c.apellidos) as empleado
                FROM usuarios a, roles b, empleados c, usuarios_empleados d
                WHERE 
	                a.idrol = b.idrol 
                    AND a.idusuario = d.idusuario 
                    AND c.idempleado = d.idempleado
                    AND usuario = '" + pUsuario + "' AND credencial = sha2('" + pClave + "', 256);");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable ValidarMedico(String pUsuario, String pClave)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT
	                a.idusuario,
                    a.usuario,
                    a.idrol, b.rol,
                    c.jvpm,
                    concat(c.nombres, ' ', c.apellidos) as medico
                FROM usuarios a, roles b, medicos c, usuarios_medicos d
                WHERE 
	                a.idrol = b.idrol 
                    AND a.idusuario = d.idusuario 
                    AND c.jvpm = d.jvpm_medico
                    AND usuario = '" + pUsuario + "' AND credencial = sha1('" + pClave + "');");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable getUsuario(String pUsuario, String pCredencial, String pIdRol, String pEstado)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append("SELECT idusuario FROM usuarios WHERE");
            Sentencia.Append(" usuario = '" + pUsuario + "'");
            Sentencia.Append(" AND credencial = sha1('" + pCredencial + "')");
            Sentencia.Append(" AND idrol = '" + pIdRol + "'");
            Sentencia.Append(" AND estado = '" + pEstado + "';");

            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }       

        public static DataTable TodosMedicos()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT
                    a.idmedico,
	                a.jvpm,
                    a.nombres,
                    a.apellidos,
                    a.genero,
                    a.fecha_nacimiento,
                    a.municipio,
                    a.direccion,
                    a.dui,
                    a.nit,
                    a.fechacontratacion,
                    a.fechasalida,
                    a.estado,
                    a.iddepartamento,
                    concat(a.direccion,', ',a.municipio,', ', (SELECT departamento FROM departamentos WHERE iddepartamento = a.iddepartamento)) as dire,
                    (SELECT MAX(idmedico)+1 from medicos) as 'idpropietario',
                    (SELECT MAX(idcontacto) from contactos) as 'idcontacto'
                FROM medicos a;");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TodasEspecialidades()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"select idespecialidad, especialidad from especialidades;");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TodosDepartamentos()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT iddepartamento, departamento FROM departamentos;");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        //public static DataTable TodosRoles()
        //{
        //    DataTable Resultado = new DataTable();
        //    StringBuilder Sentencia = new StringBuilder();
        //    DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
        //    Sentencia.Append(
        //        @"SELECT idrol, rol FROM roles;");
        //    try
        //    {
        //        Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
        //    }
        //    catch
        //    {
        //        Resultado = new DataTable();
        //    }
        //    return Resultado;
        //}

        public static DataTable TodosContactos()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT idcontacto, tipo, contacto FROM contactos;");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
    
        public static DataTable IDContactosABorrarOModificar(int idMedico)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"select a.idcontacto, b.tipo, b.contacto  from contactos_medico a, contactos b  where 
                a.idcontacto = b.idcontacto and 
                idmedico = " + idMedico + ";");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable EspecialidadesAModificar(int idMedico)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"select a.idespecialidad, b.especialidad  from especialidades_medico a, especialidades b  
                where a.idespecialidad = b.idespecialidad and idmedico = " + idMedico + ";");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
    }
}
