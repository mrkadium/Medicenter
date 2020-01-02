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
                    AND c.idmedico = d.idmedico
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

        public static DataTable getPermisosUsuario(String pUsuario)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append("select d.idopcion, d.opcion from usuarios a, permisos c, opciones d where a.usuario='" + pUsuario + "' AND a.idrol = c.idrol AND c.idopcion = d.idopcion;");

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
                    (SELECT (`AUTO_INCREMENT`) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'medicenter' AND TABLE_NAME   = 'medicos') as 'idpropietario',
                    (SELECT (`AUTO_INCREMENT`) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'medicenter' AND TABLE_NAME   = 'contactos') as 'idcontacto'
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

        public static DataTable ExamenesConsulta(int id)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT * FROM resultados_examenes WHERE idconsulta = '" + id + "';");
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

        public static DataTable TodosRoles()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT idrol, rol FROM roles;");
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

        public static DataTable IDContactosABorrarOModificarEmpleados(int idEmpleado)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"select a.idcontacto, b.tipo, b.contacto  from contactos_empleado a, contactos b  where 
                a.idcontacto = b.idcontacto and 
                idempleado = " + idEmpleado + ";");
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

        public static DataTable TodasOpciones()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT idopcion, opcion, clasificacion FROM opciones;");
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

        public static DataTable PermisosUsuario(String pUsuario)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"select d.idopcion, d.opcion from usuarios a, permisos c, 
            opciones d where a.usuario='" + pUsuario + @"' and
            a.idrol = c.idrol and c.idopcion = d.idopcion;");
            try
            {
                Resultado = oConsulta.Consultar(Sentencia.ToString());
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable TodosRolesPermisos()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"select idrol, rol from roles order by rol asc;");
            try
            {
                Resultado = oConsulta.Consultar(Sentencia.ToString());
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable ValidacionPermisos(String pIdRol)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();

            Sentencia.Append(@"
                select if ((select idpermiso from permisos x where x.idopcion = a.idopcion and x.idrol = " + pIdRol + @") 
                is null, 0, 1) as Asignado, 
                ifnull((select idpermiso from permisos x where x.idopcion = a.idopcion and x.idrol = " + pIdRol + @"), 0) 
                as IDAsignacion, 
                a.idopcion, a.opcion, a.clasificacion from opciones a;");
            try
            {
                Resultado = oConsulta.Consultar(Sentencia.ToString());
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static Boolean EliminarPermiso(int idPermiso)
        {
            Boolean p = true; 
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"delete from permisos where 
                idpermiso = " + idPermiso + ";");
            try
            {
                oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch
            {
                p = false;
            }
            return p;
        }

        public static Boolean InsertarPermiso(int idRol, int idOpcion)
        {
            Boolean p = true;
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"insert into permisos(idrol, idopcion) values(" + idRol + ", " + idOpcion + ");");
            try
            {
                oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch
            {
                p = false;
            }
            return p;
        }

        public static DataTable TodosCargos()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"select idcargo, cargo from cargos;");
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

        public static DataTable TodosPacientes()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"select idpaciente, 
		        expediente, 
		        nombres, 
		        apellidos, 
		        fecha_nacimiento,  
                genero,
		        telefono, 
		        email, 
		        municipio, 
		        iddepartamento,
                concat(a.municipio,', ', (SELECT departamento FROM departamentos WHERE iddepartamento = a.iddepartamento)) as direccion
                from pacientes a;");
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

        public static DataTable TodosUsuarios()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"select a.idusuario, 
		            a.usuario,
                    a.idrol,
                    a.estado,
                    b.rol,
                    (SELECT (`AUTO_INCREMENT`) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'medicenter' AND TABLE_NAME   = 'usuarios') as 'idusuarioNuevo',
                    if ((select x.idusuario from usuarios_empleados x where x.idusuario = a.idusuario) 
					is null, 0, 1) as 'Empleado',
                    if ((select x.idusuario from usuarios_medicos x where x.idusuario = a.idusuario) 
					is null, 0, 1) as 'Medico',
                    (select g.idmedico from usuarios_medicos g where g.idusuario = a.idusuario)
                    as 'idmedico',                    
                    (select concat(j.nombres, ' ', j.apellidos) from usuarios_medicos g, medicos j 
                    where g.idusuario = a.idusuario and g.idmedico = j.idmedico) as 'propietarioMedico',
                    (select g.idempleado from usuarios_empleados g where g.idusuario = a.idusuario)
                    as 'idempleado',
                    (select concat(j.nombres, ' ', j.apellidos) from usuarios_empleados g, empleados j 
                    where g.idusuario = a.idusuario and g.idempleado = j.idempleado) as 'propietarioEmpleado'
                    from usuarios a, 
                    roles b where a.idrol = b.idrol;");
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

        public static DataTable TodosEmpleados()
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
                    a.municipio,
                    a.direccion,
                    a.idcargo,
                    b.cargo,
                    a.fechacontratacion,
                    a.fechasalida,
                    a.estado,
                    a.iddepartamento,
                    concat(a.direccion,', ',a.municipio,', ', (SELECT departamento FROM departamentos WHERE iddepartamento = a.iddepartamento)) as dire,
                    (SELECT (`AUTO_INCREMENT`) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'medicenter' AND TABLE_NAME   = 'empleados') as 'idpropietario',
                    (SELECT (`AUTO_INCREMENT`) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'medicenter' AND TABLE_NAME   = 'contactos') as 'idcontacto'
                FROM empleados a, cargos b where a.idcargo = b.idcargo;");
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

        public static Boolean ValidarTxbUsuario(String user)
        {
            Boolean p = false;
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"select idusuario, usuario from usuarios where usuario = '" + user + "';");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch{}

            if (Convert.ToInt32(Resultado.Rows.Count.ToString()) > 0)
            {
                p = true;
            }
            return p;
        }

        public static DataTable IncapacidadMedica(String pPaciente, int pidTitular, int pIncapacidad)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"select '" + pPaciente + @"' as 'nombrePaciente', b.diagnostico, c.jvpm, 					
					if((select genero from medicos where idmedico = b.idmedico) = 'FEMENINO', 'Dra.', 'Dr.') as 'abreviacion', 
					concat(c.nombres, ' ', c.apellidos) as 'nombreMedico', 
                    '" + pIncapacidad + @"' as 'incapacidad'
                    from detalle_consulta b,
                    medicos c, operaciones d where d.idtitular = " + pidTitular + @" and
					b.idconsulta = (select idoperacion from operaciones where idtitular = "+ pidTitular + @" order by idoperacion desc limit 1) and
                    d.idoperacion = b.idconsulta and c.idmedico = b.idmedico;");
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

        public static DataTable EdadPaciente(String pPaciente, int pidMedico, int pidPaciente)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"select '" + pPaciente + @"' as 'nombrePaciente', b.jvpm, 					
		            if((select genero from medicos where idmedico = " + pidMedico + @") = 'FEMENINO', 'Dra.', 'Dr.') as 'abreviacion',
                    concat(b.nombres, ' ', b.apellidos) as 'nombreMedico',
		            truncate((year(now()) - year(a.fecha_nacimiento)), 0) as 'Edad' from pacientes a, medicos b where 
                    a.idpaciente = " + pidPaciente + @" and
                    b.idmedico = " + pidMedico + ";");
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

        public static DataTable ReporteVentasGeneral(DateTime pFechaInicio, DateTime pFechaFin)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
                    a.idoperacion,
                    c.fecha,
                    b.nombre,
                    b.alias,
                    a.cantidad,
                    a.precioventa,
                    a.gravado
                FROM detalles_operacion a,
	                consumibles b,
                    operaciones c
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'VENTA')
                    and a.idoperacion = c.idoperacion
                    and a.idconsumible = b.idconsumible
                    and date(c.fecha) between '" + pFechaInicio.ToString("yyyy/MM/dd") + "' and '" + pFechaFin.ToString("yyyy/MM/dd") + "';");
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

        public static Boolean VerificaReporteVentasGeneral(DateTime pFechaInicio, DateTime pFechaFin)
        {
            Boolean res = false;
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
                    a.idoperacion,
                    c.fecha,
                    b.nombre,
                    b.alias,
                    a.cantidad,
                    a.precioventa,
                    a.gravado
                FROM detalles_operacion a,
	                consumibles b,
                    operaciones c
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'VENTA')
                    and a.idoperacion = c.idoperacion
                    and a.idconsumible = b.idconsumible
                    and date(c.fecha) between '" + pFechaInicio.ToString("yyyy/MM/dd") + "' and '" + pFechaFin.ToString("yyyy/MM/dd") + "';");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch { }

            if (Resultado.Rows.Count > 0)
            {
                res = true;
            }
            return res;
        }

        public static DataTable ReporteVentasServicios(DateTime pFechaInicio, DateTime pFechaFin)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
                    a.idoperacion,
                    c.fecha,
                    b.nombre,
                    b.alias,
                    a.gravado
                FROM detalles_operacion a,
	                consumibles b,
                    operaciones c
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'VENTA')
                    and a.idoperacion = c.idoperacion
                    and a.idconsumible = b.idconsumible
                    and b.categoria = 'SERVICIO'
                    and date(c.fecha) between '" + pFechaInicio.ToString("yyyy/MM/dd") + "' and '" + pFechaFin.ToString("yyyy/MM/dd") + "';");
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

        public static Boolean VerificaReporteVentasServicios(DateTime pFechaInicio, DateTime pFechaFin)
        {
            Boolean res = false;
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
                    a.idoperacion,
                    c.fecha,
                    b.nombre,
                    b.alias,
                    a.gravado
                FROM detalles_operacion a,
	                consumibles b,
                    operaciones c
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'VENTA')
                    and a.idoperacion = c.idoperacion
                    and a.idconsumible = b.idconsumible
                    and b.categoria = 'SERVICIO'
                    and date(c.fecha) between '" + pFechaInicio.ToString("yyyy/MM/dd") + "' and '" + pFechaFin.ToString("yyyy/MM/dd") + "';");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch { }

            if (Resultado.Rows.Count > 0)
            {
                res = true;
            }
            return res;
        }

        public static DataTable ReporteVentasProductos(DateTime pFechaInicio, DateTime pFechaFin)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
                    a.idoperacion,
                    c.fecha,
                    b.nombre,
                    b.alias,
                    d.marca,
                    a.cantidad,
                    a.precioventa,
                    a.gravado
                FROM detalles_operacion a,
	                consumibles b,
                    operaciones c,
                    marcas d
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'VENTA')
                    and a.idoperacion = c.idoperacion
                    and a.idconsumible = b.idconsumible
                    and b.categoria = 'PRODUCTO'
                    and b.idmarca = d.idmarca
                    and date(c.fecha) between '" + pFechaInicio.ToString("yyyy/MM/dd") + "' and '" + pFechaFin.ToString("yyyy/MM/dd") + "';");
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

        public static Boolean VerificaReporteVentasProductos(DateTime pFechaInicio, DateTime pFechaFin)
        {
            Boolean res = false;
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
                    a.idoperacion,
                    c.fecha,
                    b.nombre,
                    b.alias,
                    d.marca,
                    a.cantidad,
                    a.precioventa,
                    a.gravado
                FROM detalles_operacion a,
	                consumibles b,
                    operaciones c,
                    marcas d
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'VENTA')
                    and a.idoperacion = c.idoperacion
                    and a.idconsumible = b.idconsumible
                    and b.categoria = 'PRODUCTO'
                    and b.idmarca = d.idmarca
                    and date(c.fecha) between '" + pFechaInicio.ToString("yyyy/MM/dd") + "' and '" + pFechaFin.ToString("yyyy/MM/dd") + "';");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch { }

            if (Resultado.Rows.Count > 0)
            {
                res = true;
            }
            return res;
        }

        public static DataTable ReporteVentasProductosEspecifico(int pIdProducto, DateTime pFechaInicio, DateTime pFechaFin)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
                    a.idoperacion,
                    c.fecha,
                    b.nombre,
                    b.alias,
                    d.marca,
                    a.cantidad,
                    a.precioventa,
                    a.gravado
                FROM detalles_operacion a,
	                consumibles b,
                    operaciones c,
                    marcas d
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'VENTA')
                    and a.idoperacion = c.idoperacion
                    and a.idconsumible = b.idconsumible
                    and b.categoria = 'PRODUCTO'
                    and b.idconsumible = " + pIdProducto + @"
                    and b.idmarca = d.idmarca
                    and date(c.fecha) between '" + pFechaInicio.ToString("yyyy/MM/dd") + "' and '" + pFechaFin.ToString("yyyy/MM/dd") + "';");
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

        public static Boolean VerificaReporteVentasProductosEspecifico(int pIdProducto, DateTime pFechaInicio, DateTime pFechaFin)
        {
            Boolean res = false;
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
                    a.idoperacion,
                    c.fecha,
                    b.nombre,
                    b.alias,
                    d.marca,
                    a.cantidad,
                    a.precioventa,
                    a.gravado
                FROM detalles_operacion a,
	                consumibles b,
                    operaciones c,
                    marcas d
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'VENTA')
                    and a.idoperacion = c.idoperacion
                    and a.idconsumible = b.idconsumible
                    and b.categoria = 'PRODUCTO'
                    and b.idconsumible = " + pIdProducto + @"
                    and b.idmarca = d.idmarca
                    and date(c.fecha) between '" + pFechaInicio.ToString("yyyy/MM/dd") + "' and '" + pFechaFin.ToString("yyyy/MM/dd") + "';");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch { }

            if (Resultado.Rows.Count > 0)
            {
                res = true;
            }
            return res;
        }

        public static DataTable ReporteVentasMarcaEspecifica(int pIdMarca, DateTime pFechaInicio, DateTime pFechaFin)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
                    a.idoperacion,
                    c.fecha,
                    b.nombre,
                    b.alias,
                    d.marca,
                    a.cantidad,
                    a.precioventa,
                    a.gravado
                FROM detalles_operacion a,
	                consumibles b,
                    operaciones c,
                    marcas d
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'VENTA')
                    and a.idoperacion = c.idoperacion
                    and a.idconsumible = b.idconsumible
                    and b.categoria = 'PRODUCTO'
                    and d.idmarca = " + pIdMarca + @"
                    and b.idmarca = d.idmarca
                    and date(c.fecha) between '" + pFechaInicio.ToString("yyyy/MM/dd") + "' and '" + pFechaFin.ToString("yyyy/MM/dd") + "';");
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

        public static Boolean VerificaReporteVentasMarcaEspecifica(int pIdMarca, DateTime pFechaInicio, DateTime pFechaFin)
        {
            Boolean res = false;
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
                    a.idoperacion,
                    c.fecha,
                    b.nombre,
                    b.alias,
                    d.marca,
                    a.cantidad,
                    a.precioventa,
                    a.gravado
                FROM detalles_operacion a,
	                consumibles b,
                    operaciones c,
                    marcas d
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'VENTA')
                    and a.idoperacion = c.idoperacion
                    and a.idconsumible = b.idconsumible
                    and b.categoria = 'PRODUCTO'
                    and d.idmarca = " + pIdMarca + @"
                    and b.idmarca = d.idmarca
                    and date(c.fecha) between '" + pFechaInicio.ToString("yyyy/MM/dd") + "' and '" + pFechaFin.ToString("yyyy/MM/dd") + "';");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch { }

            if (Resultado.Rows.Count > 0)
            {
                res = true;
            }
            return res;
        }

        public static DataTable ReporteCompraProductos(DateTime pFechaInicio, DateTime pFechaFin)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
                    a.idoperacion,
                    c.fecha,
                    b.nombre,
                    b.alias,
                    d.marca,
                    a.cantidad,
                    a.preciocompra as precioventa,
                    (a.preciocompra * a.cantidad) as gravado
                FROM detalles_operacion a,
	                consumibles b,
                    operaciones c,
                    marcas d
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'COMPRA')
                    and a.idoperacion = c.idoperacion
                    and a.idconsumible = b.idconsumible
                    and b.categoria = 'PRODUCTO'
                    and b.idmarca = d.idmarca
                    and date(c.fecha) between '" + pFechaInicio.ToString("yyyy/MM/dd") + "' and '" + pFechaFin.ToString("yyyy/MM/dd") + "';");
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

        public static Boolean VerificaReporteCompraProductos(DateTime pFechaInicio, DateTime pFechaFin)
        {
            Boolean res = false;
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
                    a.idoperacion,
                    c.fecha,
                    b.nombre,
                    b.alias,
                    d.marca,
                    a.cantidad,
                    a.preciocompra as precioventa,
                    (a.preciocompra * a.cantidad) as gravado
                FROM detalles_operacion a,
	                consumibles b,
                    operaciones c,
                    marcas d
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'COMPRA')
                    and a.idoperacion = c.idoperacion
                    and a.idconsumible = b.idconsumible
                    and b.categoria = 'PRODUCTO'
                    and b.idmarca = d.idmarca
                    and date(c.fecha) between '" + pFechaInicio.ToString("yyyy/MM/dd") + "' and '" + pFechaFin.ToString("yyyy/MM/dd") + "';");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch { }

            if (Resultado.Rows.Count > 0)
            {
                res = true;
            }
            return res;
        }

        public static DataTable ReporteCompraProductosEspecifico(int pIdProducto, DateTime pFechaInicio, DateTime pFechaFin)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
                    a.idoperacion,
                    c.fecha,
                    b.nombre,
                    b.alias,
                    d.marca,
                    a.cantidad,
                    a.preciocompra as precioventa,
                    (a.preciocompra * a.cantidad) as gravado
                FROM detalles_operacion a,
	                consumibles b,
                    operaciones c,
                    marcas d
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'COMPRA')
                    and a.idoperacion = c.idoperacion
                    and a.idconsumible = b.idconsumible
                    and b.categoria = 'PRODUCTO'
                    and b.idconsumible = " + pIdProducto + @"
                    and b.idmarca = d.idmarca
                    and date(c.fecha) between '" + pFechaInicio.ToString("yyyy/MM/dd") + "' and '" + pFechaFin.ToString("yyyy/MM/dd") + "';");
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

        public static Boolean VerificaReporteCompraProductosEspecifico(int pIdProducto, DateTime pFechaInicio, DateTime pFechaFin)
        {
            Boolean res = false;
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
                    a.idoperacion,
                    c.fecha,
                    b.nombre,
                    b.alias,
                    d.marca,
                    a.cantidad,
                    a.preciocompra as precioventa,
                    (a.preciocompra * a.cantidad) as gravado
                FROM detalles_operacion a,
	                consumibles b,
                    operaciones c,
                    marcas d
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'COMPRA')
                    and a.idoperacion = c.idoperacion
                    and a.idconsumible = b.idconsumible
                    and b.categoria = 'PRODUCTO'
                    and b.idconsumible = " + pIdProducto + @"
                    and b.idmarca = d.idmarca
                    and date(c.fecha) between '" + pFechaInicio.ToString("yyyy/MM/dd") + "' and '" + pFechaFin.ToString("yyyy/MM/dd") + "';");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch { }

            if (Resultado.Rows.Count > 0)
            {
                res = true;
            }
            return res;
        }

        public static DataTable ReporteCompraMarcaEspecifica(int pIdMarca, DateTime pFechaInicio, DateTime pFechaFin)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
                    a.idoperacion,
                    c.fecha,
                    b.nombre,
                    b.alias,
                    d.marca,
                    a.cantidad,
                    a.preciocompra as precioventa,
                    (a.preciocompra * a.cantidad) as gravado
                FROM detalles_operacion a,
	                consumibles b,
                    operaciones c,
                    marcas d
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'COMPRA')
                    and a.idoperacion = c.idoperacion
                    and a.idconsumible = b.idconsumible
                    and b.categoria = 'PRODUCTO'
                    and d.idmarca = " + pIdMarca + @"
                    and b.idmarca = d.idmarca
                    and date(c.fecha) between '" + pFechaInicio.ToString("yyyy/MM/dd") + "' and '" + pFechaFin.ToString("yyyy/MM/dd") + "';");
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

        public static Boolean VerificaReporteCompraMarcaEspecifica(int pIdMarca, DateTime pFechaInicio, DateTime pFechaFin)
        {
            Boolean res = false;
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
                    a.idoperacion,
                    c.fecha,
                    b.nombre,
                    b.alias,
                    d.marca,
                    a.cantidad,
                    a.preciocompra as precioventa,
                    (a.preciocompra * a.cantidad) as gravado
                FROM detalles_operacion a,
	                consumibles b,
                    operaciones c,
                    marcas d
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'COMPRA')
                    and a.idoperacion = c.idoperacion
                    and a.idconsumible = b.idconsumible
                    and b.categoria = 'PRODUCTO'
                    and d.idmarca = " + pIdMarca + @"
                    and b.idmarca = d.idmarca
                    and date(c.fecha) between '" + pFechaInicio.ToString("yyyy/MM/dd") + "' and '" + pFechaFin.ToString("yyyy/MM/dd") + "';");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch { }

            if (Resultado.Rows.Count > 0)
            {
                res = true;
            }
            return res;
        }

        public static DataTable ReporteInventario()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT
	                a.idconsumible, 
                    b.nombre,
                    SUM(a.cantidad) AS cantidad,
                    c.marca,
                    a.preciocompra, 
                    a.precioventa
                FROM detalles_operacion a, consumibles b, marcas c
                WHERE
	                a.idoperacion IN (SELECT idoperacion FROM operaciones WHERE categoria = 'INVENTARIO')
                    AND a.idconsumible = b.idconsumible
                    AND b.idmarca = c.idmarca
                    AND a.idconsumible IN (SELECT x.idconsumible FROM consumibles x WHERE x.categoria = 'PRODUCTO')
                GROUP BY a.idconsumible;");
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

        public static Boolean VerificaReporteInventario()
        {
            Boolean res = false;
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT
	                a.idconsumible, 
                    b.nombre,
                    SUM(a.cantidad) AS cantidad,
                    c.marca,
                    a.preciocompra, 
                    a.precioventa
                FROM detalles_operacion a, consumibles b, marcas c
                WHERE
	                a.idoperacion IN (SELECT idoperacion FROM operaciones WHERE categoria = 'INVENTARIO')
                    AND a.idconsumible = b.idconsumible
                    AND b.idmarca = c.idmarca
                    AND a.idconsumible IN (SELECT x.idconsumible FROM consumibles x WHERE x.categoria = 'PRODUCTO')
                GROUP BY a.idconsumible;");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch { }

            if (Resultado.Rows.Count > 0)
            {
                res = true;
            }
            return res;
        }

        public static DataTable ReporteInventarioMarcaEspeci(int pIdMarca)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT
	                a.idconsumible, 
                    b.nombre,
                    SUM(a.cantidad) AS cantidad,
                    c.marca,
                    a.preciocompra, 
                    a.precioventa
                FROM detalles_operacion a, consumibles b, marcas c
                WHERE
	                a.idoperacion IN (SELECT idoperacion FROM operaciones WHERE categoria = 'INVENTARIO')
                    AND a.idconsumible = b.idconsumible
                    AND b.idmarca = c.idmarca
                    AND b.idmarca = " + pIdMarca + @"
                    AND a.idconsumible IN (SELECT x.idconsumible FROM consumibles x WHERE x.categoria = 'PRODUCTO')
                GROUP BY a.idconsumible;");
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

        public static Boolean VerificaReporteInventarioMarcaEspecifi(int pIdMarca)
        {
            Boolean res = false;
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT
	                a.idconsumible, 
                    b.nombre,
                    SUM(a.cantidad) AS cantidad,
                    c.marca,
                    a.preciocompra, 
                    a.precioventa
                FROM detalles_operacion a, consumibles b, marcas c
                WHERE
	                a.idoperacion IN (SELECT idoperacion FROM operaciones WHERE categoria = 'INVENTARIO')
                    AND a.idconsumible = b.idconsumible
                    AND b.idmarca = c.idmarca
                    AND b.idmarca = " + pIdMarca + @"
                    AND a.idconsumible IN (SELECT x.idconsumible FROM consumibles x WHERE x.categoria = 'PRODUCTO')
                GROUP BY a.idconsumible;");
            try
            {
                Resultado = oConsulta.EjecutarConsulta(Sentencia.ToString());
            }
            catch { }

            if (Resultado.Rows.Count > 0)
            {
                res = true;
            }
            return res;
        }

        public static DataTable TodasMarcas()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"select * from marcas;");
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

        public static DataTable TodosProveedores()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
	a.*, b.departamento
FROM laboratorios a, departamentos b
WHERE
	a.iddepartamento = b.iddepartamento;");
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

        public static DataTable TodosConsumibles()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"select a.*, (SELECT marca FROM marcas x WHERE x.idmarca = a.idmarca) as marca from consumibles a;");
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

        public static DataTable DetalleCompra(int id)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT a.*, b.nombre AS consumible FROM detalles_operacion a, consumibles b WHERE a.idconsumible = b.idconsumible AND idoperacion = '" + id + "';");
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

        public static DataTable InventariosConsumible(int id)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
	                a.*
                FROM detalles_operacion a
                WHERE
	                a.idoperacion IN (SELECT x.idoperacion FROM operaciones x WHERE x.categoria = 'INVENTARIO')
                    AND a.idconsumible = '" + id + @"'
                ORDER BY a.fecha_caducidad;");
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

        public static DataTable SoloProductos()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT
                    a.*, b.marca
                FROM consumibles a, marcas b WHERE categoria = 'PRODUCTO' AND a.idmarca = b.idmarca; ");
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

        public static DataTable SoloConsultas()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT
                    a.*, b.marca
                FROM consumibles a, marcas b WHERE categoria = 'SERVICIO' AND a.idmarca = b.idmarca; ");
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

        public static DataTable Clinica(int id)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT nombre FROM laboratorios WHERE idlaboratorio = '" + id + "';");
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

        public static DataTable LastInsertedOperaciones()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT AUTO_INCREMENT-1 AS last_id FROM information_schema.TABLES where  TABLE_SCHEMA = 'medicenter' AND TABLE_NAME = 'operaciones';");
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

        public static DataTable LastInsertedConsumibles()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT AUTO_INCREMENT-1 AS last_id FROM information_schema.TABLES where  TABLE_SCHEMA = 'medicenter' AND TABLE_NAME = 'consumibles';");
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

        public static DataTable TodosConsumiblesCmb()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT
	                idconsumible, nombre
                FROM consumibles WHERE categoria = 'PRODUCTO';");
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

        public static DataTable PrecioCompraVenta(String id)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT preciocompra, precioventa FROM consumibles WHERE idconsumible = '" + id + "';");
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

        public static DataTable TodasCompras()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
	                a.idoperacion,
                    a.idlaboratorio AS idproveedor, b.nombre AS proveedor, a.fecha,
                    SUM(c.cantidad) AS cant_productos,
                    SUM(c.preciocompra*c.cantidad) AS total_compra
                FROM operaciones a, laboratorios b, detalles_operacion c
                WHERE
	                a.idoperacion = c.idoperacion
                    AND a.idlaboratorio = b.idlaboratorio
	                AND a.categoria = 'COMPRA'
                GROUP BY a.idoperacion;");
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

        public static DataTable TodosInventarios()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT
	                a.idconsumible, b.nombre,
                    SUM(a.cantidad) AS cantidad,
                    a.preciocompra, a.precioventa
                FROM detalles_operacion a, consumibles b
                WHERE
	                a.idoperacion IN (SELECT idoperacion FROM operaciones WHERE categoria = 'INVENTARIO')
                    AND a.idconsumible = b.idconsumible
                    AND a.idconsumible IN (SELECT x.idconsumible FROM consumibles x WHERE x.categoria = 'PRODUCTO')
                GROUP BY a.idconsumible;");
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

        public static DataTable TodosInventariosConServicios()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT
	                a.idconsumible, b.nombre,
                    SUM(a.cantidad) AS cantidad,
                    a.preciocompra, a.precioventa
                FROM detalles_operacion a, consumibles b
                WHERE
	                a.idoperacion IN (SELECT idoperacion FROM operaciones WHERE categoria = 'INVENTARIO')
                    AND a.idconsumible = b.idconsumible
                GROUP BY a.idconsumible;");
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

        public static DataTable TodasVentas()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
	                a.idoperacion,
                    a.idtitular, a.titular, a.fecha,
                    SUM(c.cantidad) AS cant_productos,
                    SUM(c.precioventa*c.cantidad) AS total_venta
                FROM operaciones a, detalles_operacion c
                WHERE
	                a.idoperacion = c.idoperacion
	                AND a.categoria = 'VENTA'
                GROUP BY a.idoperacion;");
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

        public static DataTable TodasConsultas()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DBManager.CLS.DBOperacion oConsulta = new DBManager.CLS.DBOperacion();
            Sentencia.Append(
                @"SELECT 
	                a.idoperacion,
	                b.idtitular AS idpaciente, b.titular AS paciente,
                    c.nombre AS servicio,
                    CONCAT(e.nombres,' ',e.apellidos) as medico,
                    b.fecha
                FROM detalles_operacion a, operaciones b, consumibles c, detalle_consulta d, medicos e
                WHERE 
	                a.idoperacion = b.idoperacion
                    AND a.idconsumible = c.idconsumible
                    AND a.idoperacion = d.idconsulta
                    AND d.idmedico = e.idmedico
	                AND a.idconsumible IN (SELECT idconsumible FROM consumibles WHERE categoria = 'SERVICIO');");
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
