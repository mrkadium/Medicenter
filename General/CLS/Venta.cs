using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Venta
    {
        bool _Consulta = false;

        int _ID;
        int _IDTitular;
        String _Titular;
        String _Categoria;
        DateTime _Fecha;
        int _IDLaboratorio;
        List<VMConsumible> _ListaProductos = new List<VMConsumible>();

        int _IDConsulta;
        int _IDMedico;
        String _RazonConsulta = "";
        String _Temperatura = "";
        String _FrecuenciaCardiaca = "";
        String _FrecuenciaRespiratoria = "";
        String _PresionArterial = "";
        String _SaturacionOxigeno = "";
        String _Diagnostico = "";
        String _Tratamiento = "";
        String _Observaciones = "";


        public int IDTitular { get => _IDTitular; set => _IDTitular = value; }
        public int ID { get => _ID; set => _ID = value; }
        public string Titular { get => _Titular; set => _Titular = value; }
        public string Categoria { get => _Categoria; set => _Categoria = value; }
        public int IDLaboratorio { get => _IDLaboratorio; set => _IDLaboratorio = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public bool Consulta { get => _Consulta; set => _Consulta = value; }
        public int IDConsulta { get => _IDConsulta; set => _IDConsulta = value; }
        public int IDMedico { get => _IDMedico; set => _IDMedico = value; }
        public string RazonConsulta { get => _RazonConsulta; set => _RazonConsulta = value; }
        public string Diagnostico { get => _Diagnostico; set => _Diagnostico = value; }
        public string Tratamiento { get => _Tratamiento; set => _Tratamiento = value; }
        public string Observaciones { get => _Observaciones; set => _Observaciones = value; }
        public string Temperatura { get => _Temperatura; set => _Temperatura = value; }
        public string FrecuenciaCardiaca { get => _FrecuenciaCardiaca; set => _FrecuenciaCardiaca = value; }
        public string FrecuenciaRespiratoria { get => _FrecuenciaRespiratoria; set => _FrecuenciaRespiratoria = value; }
        public string PresionArterial { get => _PresionArterial; set => _PresionArterial = value; }
        public string SaturacionOxigeno { get => _SaturacionOxigeno; set => _SaturacionOxigeno = value; }
        internal List<VMConsumible> ListaProductos { get => _ListaProductos; set => _ListaProductos = value; }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            StringBuilder SentenciaVenta = new StringBuilder();
            StringBuilder SentenciaDetalles = new StringBuilder();
            StringBuilder SentenciaDetallesConsulta = new StringBuilder();

            SentenciaVenta.Append("INSERT INTO operaciones (idtitular, titular, categoria, fecha, idlaboratorio) VALUES (");
            SentenciaVenta.Append("'" + _IDTitular + "',");
            SentenciaVenta.Append("'" + _Titular + "',");
            SentenciaVenta.Append("'VENTA',");
            SentenciaVenta.Append("NOW(),");
            SentenciaVenta.Append("'" + _IDLaboratorio + "');");

            DBManager.CLS.DBOperacion oOperacion = new DBManager.CLS.DBOperacion();
            try
            {
                //SE INSERTA LA VENTA
                if (oOperacion.Insertar(SentenciaVenta.ToString()) > 0)
                {
                    Guardado = true;
                }
                else
                {
                    Guardado = false;
                }

                //SE OBTIENE EL ID DE LA OPERACIÓN INGRESADA
                String idoperacion = CacheManager.SystemCache.LastInsertedOperaciones().Rows[0].ItemArray[0].ToString();

                SentenciaDetalles.Append("INSERT INTO detalles_operacion(idoperacion, idconsumible, cantidad, precioventa, fecha_caducidad) VALUES ");
                for (int i = 0; i < ListaProductos.Count; i++)
                {
                    SentenciaDetalles.Append("('" + idoperacion + "',");
                    SentenciaDetalles.Append("'" + ListaProductos[i].IDConsumible + "',");
                    SentenciaDetalles.Append("'" + ListaProductos[i].Cantidad + "',");
                    SentenciaDetalles.Append("'" + ListaProductos[i].PrecioVenta.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "', NOW())");


                    //SE ACTUALIZAN LAS EXISTENCIAS EN EL INVENTARIO
                    bool seguir = true;
                    String updateExistencias = "";
                    int cantidad = ListaProductos[i].Cantidad;
                    DataTable d = CacheManager.SystemCache.InventariosConsumible(ListaProductos[i].IDConsumible);
                    for (int j = 0; j < d.Rows.Count; j++)
                    {
                        //SI AÚN NO SE CONSIGUE LA CANTIDAD SOLICITADA
                        if (seguir)
                        {
                            //SI EXISTENCIA DE ESE LOTE ES MENOR A CANTIDAD
                            if (int.Parse(d.Rows[j].ItemArray[3].ToString()) - cantidad < 0)
                            {
                                seguir = true;
                                //LA CANTIDAD SOLICITADA SE REDUCE Y ESE LOTE SERÁ 0
                                cantidad = cantidad - int.Parse(d.Rows[j].ItemArray[3].ToString());
                                updateExistencias = "UPDATE detalles_operacion SET cantidad = 0 WHERE iddetalle = '" + d.Rows[j].ItemArray[0].ToString() + "' AND idconsumible IN (SELECT x.idconsumible FROM consumibles x WHERE x.categoria = 'PRODUCTO');";
                                Guardado = oOperacion.Actualizar(updateExistencias.ToString()) > 0 ? true : false;
                            }
                            else if (int.Parse(d.Rows[j].ItemArray[3].ToString()) - cantidad > 0)
                            {
                                seguir = false;
                                //LA CANTIDAD SOLICITADA ES 0 Y EL LOTE SE REDUCE A LA DIFERENCIA
                                updateExistencias = "UPDATE detalles_operacion SET cantidad = '" + (int.Parse(d.Rows[j].ItemArray[3].ToString()) - cantidad) + "' WHERE iddetalle = '" + d.Rows[j].ItemArray[0].ToString() + "' AND idconsumible IN (SELECT x.idconsumible FROM consumibles x WHERE x.categoria = 'PRODUCTO');";
                                Guardado = oOperacion.Actualizar(updateExistencias.ToString()) > 0 ? true : false;
                            }
                            else //SI LA RESTA DA 0
                            {
                                seguir = false;
                                updateExistencias = "UPDATE detalles_operacion SET cantidad = 0 WHERE iddetalle = '" + d.Rows[j].ItemArray[0].ToString() + "' AND idconsumible IN (SELECT x.idconsumible FROM consumibles x WHERE x.categoria = 'PRODUCTO');";
                                Guardado = oOperacion.Actualizar(updateExistencias.ToString()) > 0 ? true : false;
                            }
                        }
                    }


                    if ((i + 1) == ListaProductos.Count)
                    {
                        SentenciaDetalles.Append(";");
                    }
                    else
                    {
                        SentenciaDetalles.Append(",");
                    }
                }
                //SE INSERTA CADA CONSUMIBLE DE LA VENTA
                if (oOperacion.Insertar(SentenciaDetalles.ToString()) > 0)
                {
                    Guardado = true;
                }
                else
                {
                    Guardado = false;
                }

                //SE INSERTAN LOS DETALLES DE LA CONSULTA
                if (_Consulta) //SI ES CONSULTA
                {
                    SentenciaDetallesConsulta.Append("INSERT INTO detalle_consulta (idconsulta, idmedico, razonconsulta, temperatura, frecuenciacardiaca, frecuenciarespiratoria, presionarterial, saturacionoxigeno, diagnostico, tratamiento, observaciones) VALUES ");
                    SentenciaDetallesConsulta.Append("(");
                    SentenciaDetallesConsulta.Append("'" + idoperacion + "',");
                    SentenciaDetallesConsulta.Append("'" + _IDMedico + "',");
                    SentenciaDetallesConsulta.Append("'" + _RazonConsulta + "',");
                    SentenciaDetallesConsulta.Append("'" + _Temperatura + "',");
                    SentenciaDetallesConsulta.Append("'" + _FrecuenciaCardiaca + "',");
                    SentenciaDetallesConsulta.Append("'" + _FrecuenciaRespiratoria + "',");
                    SentenciaDetallesConsulta.Append("'" + _PresionArterial + "',");
                    SentenciaDetallesConsulta.Append("'" + _SaturacionOxigeno + "',");
                    SentenciaDetallesConsulta.Append("'" + _Diagnostico + "',");
                    SentenciaDetallesConsulta.Append("'" + _Tratamiento + "',");
                    SentenciaDetallesConsulta.Append("'" + _Observaciones + "');");

                    if (oOperacion.Insertar(SentenciaDetallesConsulta.ToString()) > 0)
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
}
