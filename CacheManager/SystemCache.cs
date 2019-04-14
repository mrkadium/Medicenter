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
        public static DataTable Todos_empleados()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"select * from empleados order by apellidos, nombres;");
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
        public static DataTable Todos_usuarios()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT
	                a.idUsuario,
	                a.usuario,
                    a.credencial,
                    a.idEmpleado,
                    concat(b.nombres,' ', b.apellidos) as empleado,
                    a.idRol,
                    c.rol,
                    a.estado
                FROM usuarios a, empleados b, roles c
                WHERE a.idEmpleado = b.idEmpleado AND a.idRol = c.idRol;");
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
        public static DataTable Todos_roles()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT * FROM roles;");
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
