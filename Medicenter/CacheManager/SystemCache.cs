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
                @"select a.idusuario, a.usuario, concat(d.nombres, ' ', d.apellidos) as empleado, 
                a.idrol, b.rol, c.idempleado from usuarios a, roles b, usuarios_empleados c,
                empleados d where a.idrol=b.idrol and a.idusuario = c.idempleado and 
                c.idempleado = d.idempleado and a.usuario = '" + pUsuario+"' and a.clave = sha1('"+pClave+"'); ");
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
