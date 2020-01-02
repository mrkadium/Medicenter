using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Consumible
    {
        int _IDConsumible;
        String _Categoria;
        String _Nombre;
        String _Alias;
        int _IDMarca;
        Double _PrecioCompra;
        Double _PrecioVenta;

        public int IDConsumible { get => _IDConsumible; set => _IDConsumible = value; }
        public string Categoria { get => _Categoria; set => _Categoria = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Alias { get => _Alias; set => _Alias = value; }
        public int IDMarca { get => _IDMarca; set => _IDMarca = value; }
        public double PrecioCompra { get => _PrecioCompra; set => _PrecioCompra = value; }
        public double PrecioVenta { get => _PrecioVenta; set => _PrecioVenta = value; }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO consumibles (categoria, nombre, alias, idmarca, preciocompra, precioventa) VALUES (");
            Sentencia.Append("'" + _Categoria + "',");
            Sentencia.Append("'" + _Nombre + "',");
            Sentencia.Append("'" + _Alias + "',");
            Sentencia.Append("'" + _IDMarca + "',");
            Sentencia.Append("'" + _PrecioCompra.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "',");
            Sentencia.Append("'" + _PrecioVenta.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "');");

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

                if (_Categoria.Equals("SERVICIO"))
                {
                    String clinica = CacheManager.SystemCache.Clinica(1).Rows[0][0].ToString();

                    String agregarInventario = 
                        "INSERT INTO operaciones (idtitular, titular, categoria, fecha, idlaboratorio) " +
                        "VALUES (1, '" + clinica + "', 'INVENTARIO', NOW(), 1);";

                    if (oOperacion.Insertar(agregarInventario) > 0)
                    {
                        Guardado = true;
                    }
                    else
                    {
                        Guardado = false;
                    }

                    String idoperacion = CacheManager.SystemCache.LastInsertedOperaciones().Rows[0]["last_id"].ToString();
                    String idconsumible = CacheManager.SystemCache.LastInsertedConsumibles().Rows[0]["last_id"].ToString();


                    String agregarDetalleInventario =
                        "INSERT INTO detalles_operacion (idoperacion, idconsumible, cantidad, precioventa, fecha_caducidad) " +
                        "VALUES ('" + idoperacion + "', '" + idconsumible + "', 1, " + _PrecioVenta + ", '3000-01-01');";
                    if (oOperacion.Insertar(agregarDetalleInventario) > 0)
                    {
                        Guardado = true;
                    }
                    else
                    {
                        Guardado = false;
                    }
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
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("UPDATE consumibles SET ");
            Sentencia.Append("categoria='" + _Categoria + "',");
            Sentencia.Append("nombre='" + _Nombre + "',");
            Sentencia.Append("alias='" + _Alias + "',");
            Sentencia.Append("idmarca='" + _IDMarca + "',");
            Sentencia.Append("preciocompra='" + _PrecioCompra.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "',");
            Sentencia.Append("precioventa='" + _PrecioVenta.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "' WHERE idconsumible='" + _IDConsumible + "';");
            DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();
            try
            {
                if (oOperacion.Actualizar(Sentencia.ToString()) > 0)
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

        public Boolean Eliminar()
        {
            Boolean Guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("DELETE FROM consumibles ");
            Sentencia.Append("WHERE idconsumible='" + _IDConsumible + "';");
            DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();
            try
            {
                if (oOperacion.Eliminar(Sentencia.ToString()) > 0)
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
    }
}
