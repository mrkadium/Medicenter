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
                @"select
                    a.idUsuario, a.usuario,
                    b.idRol, b.rol,
                    c.idEmpleado, concat(c.nombres, ' ', c.apellidos) as empleado
                from usuarios a, roles b, empleados c
                where a.idRol = b.idRol and a.idEmpleado = c.idEmpleado and a.usuario = '"+pUsuario+"' and a.credencial = sha1('"+pClave+"'); ");
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
    }
}
