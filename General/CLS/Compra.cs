using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Compra
    {
        int _ID;
        int _IDTitular;
        String _Titular;
        String _Categoria;
        DateTime _Fecha;
        int _IDLaboratorio;
        List<VMConsumible> _ListaProductos = new List<VMConsumible>();


        public int IDTitular { get => _IDTitular; set => _IDTitular = value; }
        public int ID { get => _ID; set => _ID = value; }
        public string Titular { get => _Titular; set => _Titular = value; }
        public string Categoria { get => _Categoria; set => _Categoria = value; }
        public int IDLaboratorio { get => _IDLaboratorio; set => _IDLaboratorio = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        internal List<VMConsumible> ListaProductos { get => _ListaProductos; set => _ListaProductos = value; }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder SentenciaCompra = new StringBuilder();
            StringBuilder SentenciaInventario = new StringBuilder();
            StringBuilder SentenciaDetalles = new StringBuilder();

            //QUERY PARA INSERTAR COMPRA
            SentenciaCompra.Append("INSERT INTO operaciones (idtitular, titular, categoria, fecha, idlaboratorio) VALUES (");
            SentenciaCompra.Append("'" + _IDTitular + "',");
            SentenciaCompra.Append("'" + _Titular + "',");
            SentenciaCompra.Append("'COMPRA',");
            SentenciaCompra.Append("NOW(),");
            SentenciaCompra.Append("'" + _IDLaboratorio + "');");

            //QUERY PARA INSERTAR INVENTARIO
            SentenciaInventario.Append("INSERT INTO operaciones (idtitular, titular, categoria, fecha, idlaboratorio) VALUES (");
            SentenciaInventario.Append("'" + _IDTitular + "',");
            SentenciaInventario.Append("'" + _Titular + "',");
            SentenciaInventario.Append("'INVENTARIO',");
            SentenciaInventario.Append("NOW(),");
            SentenciaInventario.Append("'" + _IDLaboratorio + "');");
            

            DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();
            try
            {
                //SE INSERTA LA COMPRA
                if (oOperacion.Insertar(SentenciaCompra.ToString()) > 0)
                {
                    Guardado = true;
                }
                else
                {
                    Guardado = false;
                }
                //SE TOMA EL ÚLTIMO ID INSERTADO EN OPERACIONES PARA INSERTAR LOS DETALLES
                String idoperacion = CacheManager.SystemCache.LastInsertedOperaciones().Rows[0].ItemArray[0].ToString();
                SentenciaDetalles.Append("INSERT INTO detalles_operacion(idoperacion, idconsumible, cantidad, preciocompra, precioventa, fecha_caducidad) VALUES ");
                for (int i = 0; i < ListaProductos.Count; i++)
                {
                    SentenciaDetalles.Append("('" + idoperacion + "',");
                    SentenciaDetalles.Append("'" + ListaProductos[i].IDConsumible + "',");
                    SentenciaDetalles.Append("'" + ListaProductos[i].Cantidad + "',");
                    SentenciaDetalles.Append("'" + ListaProductos[i].PrecioCompra.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "',");
                    SentenciaDetalles.Append("'" + ListaProductos[i].PrecioVenta.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "', NOW())");

                    //ACTUALIZAR LOS PRECIOS DE CADA PRODUCTO
                    String UpdatePrecioConsumible = 
                        "UPDATE consumibles SET " +
                        "preciocompra = '"+ ListaProductos[i].PrecioCompra.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "', " +
                        "precioventa = '" + ListaProductos[i].PrecioVenta.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "' " +
                        "WHERE idconsumible = '" + ListaProductos[i].IDConsumible.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "'";
                    //SE EJECUTA LA ACTUALIZACIÓN PARA CADA PRODUCTO
                    Guardado = oOperacion.Actualizar(UpdatePrecioConsumible.ToString()) > 0 ? true : false;

                    //ACTUALIZAR LOS PRECIOS DE CADA INVENTARIO
                    String UpdatePrecioInventario = 
                        "UPDATE detalles_operacion SET " +
                        "preciocompra = '" + ListaProductos[i].PrecioCompra.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "', " +
                        "precioventa = '" + ListaProductos[i].PrecioVenta.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "' " +
                        "WHERE idconsumible = '" + ListaProductos[i].IDConsumible + "'" +
                        "AND idoperacion IN (SELECT idoperacion FROM operaciones WHERE categoria = 'INVENTARIO')";
                    //SE EJECUTA LA ACTUALIZACIÓN PARA CADA PRODUCTO
                    Guardado = oOperacion.Actualizar(UpdatePrecioInventario.ToString()) > 0 ? true : false;

                    if ((i+1) == ListaProductos.Count)
                    {
                        SentenciaDetalles.Append(";");
                    }
                    else
                    {
                        SentenciaDetalles.Append(",");
                    }
                }
                //SE INSERTAN LOS DETALLES DE LA OPERACIÓN CON CADA PRODUCTO
                if (oOperacion.Insertar(SentenciaDetalles.ToString()) > 0)
                {
                    Guardado = true;
                }
                else
                {
                    Guardado = false;
                }


                //LO MISMO, PERO PARA INVENTARIOS
                if (oOperacion.Insertar(SentenciaInventario.ToString()) > 0)
                {
                    Guardado = true;
                }
                else
                {
                    Guardado = false;
                }
                idoperacion = CacheManager.SystemCache.LastInsertedOperaciones().Rows[0].ItemArray[0].ToString();
                SentenciaDetalles.Clear();
                SentenciaDetalles.Append("INSERT INTO detalles_operacion(idoperacion, idconsumible, cantidad, preciocompra, precioventa, fecha_caducidad) VALUES ");
                for (int i = 0; i < ListaProductos.Count; i++)
                {
                    SentenciaDetalles.Append("('" + idoperacion + "',");
                    SentenciaDetalles.Append("'" + ListaProductos[i].IDConsumible + "',");
                    SentenciaDetalles.Append("'" + ListaProductos[i].Cantidad + "',");
                    SentenciaDetalles.Append("'" + ListaProductos[i].PrecioCompra.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "',");
                    SentenciaDetalles.Append("'" + ListaProductos[i].PrecioVenta.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "', NOW())");
                    if ((i + 1) == ListaProductos.Count)
                    {
                        SentenciaDetalles.Append(";");
                    }
                    else
                    {
                        SentenciaDetalles.Append(",");
                    }
                }
                if (oOperacion.Insertar(SentenciaDetalles.ToString()) > 0)
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

        //public Boolean Actualizar()
        //{
        //    Boolean Guardado = false;
        //    StringBuilder Sentencia = new StringBuilder();
        //    Sentencia.Append("UPDATE marcas SET ");
        //    Sentencia.Append("marca='" + _Marca + "' WHERE idmarca='" + _IDMarca + "';");
        //    DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();
        //    try
        //    {
        //        if (oOperacion.Actualizar(Sentencia.ToString()) > 0)
        //        {
        //            Guardado = true;
        //        }
        //        else
        //        {
        //            Guardado = false;
        //        }
        //    }
        //    catch
        //    {
        //        Guardado = false;
        //    }
        //    return Guardado;
        //}

        //public Boolean Eliminar()
        //{
        //    Boolean Guardado = false;
        //    StringBuilder Sentencia = new StringBuilder();
        //    Sentencia.Append("DELETE FROM marcas ");
        //    Sentencia.Append("WHERE idmarca='" + _IDMarca + "';");
        //    DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();
        //    try
        //    {
        //        if (oOperacion.Eliminar(Sentencia.ToString()) > 0)
        //        {
        //            Guardado = true;
        //        }
        //        else
        //        {
        //            Guardado = false;
        //        }
        //    }
        //    catch
        //    {
        //        Guardado = false;
        //    }
        //    return Guardado;
        //}
    }
    class VMConsumible
    {
        int _IDConsumible;
        String _Consumible;
        int _Cantidad;
        Double _PrecioCompra;
        Double _PrecioVenta;
        float _PVenta;

        public int IDConsumible { get => _IDConsumible; set => _IDConsumible = value; }
        public string Consumible { get => _Consumible; set => _Consumible = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public double PrecioCompra { get => _PrecioCompra; set => _PrecioCompra = value; }
        public double PrecioVenta { get => _PrecioVenta; set => _PrecioVenta = value; }
        public float PVenta { get => _PVenta; set => _PVenta = value; }
    }
}
