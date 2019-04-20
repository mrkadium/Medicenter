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

        public static DataTable Todos_empleados()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT
	                a.idempleado,
                    a.nombres,
                    a.apellidos,
                    a.genero,
                    a.fecha_nacimiento,
                    a.dui,
                    a.nit,
                    c.departamento,
                    a.municipio,
                    a.direccion,
                    b.cargo,
                    a.fechacontratacion,
                    a.fechasalida,
                    a.estado
                FROM empleados a, cargos b, departamentos c
                WHERE a.idcargo = b.idcargo AND c.iddepartamento = a.iddepartamento;");
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

        public static DataTable Todos_medicos()
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
                    concat(a.direccion,', ',a.municipio,', ', (SELECT departamento FROM departamentos WHERE iddepartamento = a.iddepartamento)) as dire
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

        public static DataTable Todos_usuarios_empleados()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT
	                a.idusuario,
                    a.usuario,
                    a.credencial,
                    a.idrol, b.rol,
                    c.idempleado,
                    concat(c.nombres, ' ', c.apellidos) as empleado,
                    a.estado
                FROM usuarios a, roles b, empleados c, usuarios_empleados d
                WHERE 
	                a.idrol = b.idrol 
                    AND a.idusuario = d.idusuario 
                    AND c.idempleado = d.idempleado
                    AND usuario = 'mario.rivera' AND credencial = sha1('admin');");
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

        public static DataTable Todos_usuarios_medicos()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT
	                a.idusuario,
                    a.usuario,
                    a.credencial,
                    a.idrol, b.rol,
                    c.jvpm,
                    concat(c.nombres, ' ', c.apellidos) as medico,
                    a.estado
                FROM usuarios a, roles b, medicos c, usuarios_medicos d
                WHERE 
	                a.idrol = b.idrol 
                    AND a.idusuario = d.idusuario 
                    AND c.jvpm = d.jvpm_medico
                    AND usuario = 'meredith.grey' AND credencial = sha1('admin');");
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

        public static DataTable Todos_cargos()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT * FROM cargos;");
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

        public static DataTable Todos_departamentos()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT * FROM departamentos;");
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

        public static DataTable Contactos(String pPropietario, String pPara)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT * FROM contactos WHERE idpropietario = '"+pPropietario+"' AND para = '"+pPara+"';");
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
