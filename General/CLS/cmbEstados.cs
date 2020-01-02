using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace General.CLS
{
    public class cmbEstados 
    {
        public String Dmember { get; set; }
        public String Vmember { get; set; }
        public cmbEstados(String dmem, String vmem)
        {
            Dmember = dmem;
            Vmember = vmem;
        }

        public static String ConvertToDot(String number)
        {
            String nuevo = "";
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i].ToString().Equals(","))
                {
                    nuevo += ".";
                }
                else
                {
                    nuevo += number[i];
                }
            }
            return nuevo;
        }

        public static cmbEstados[] Estados()
        {
            return new cmbEstados[] {
                    new cmbEstados("ACTIVO", "ACTIVO"),
                    new cmbEstados("INACTIVO", "INACTIVO")
                };
        }

        public static cmbEstados[] EstadosUsuarios()
        {
            return new cmbEstados[] {
                    new cmbEstados("ACTIVO", "ACTIVO"),
                    new cmbEstados("BLOQUEADO", "BLOQUEADO")
                };
        }

        public static cmbEstados[] Generos()
        {
            return new cmbEstados[] {
                    new cmbEstados("FEMENINO", "FEMENINO"),
                    new cmbEstados("MASCULINO", "MASCULINO")
                };
        }

        public static cmbEstados[] TipoContacto()
        {
            return new cmbEstados[] {
                    new cmbEstados("TELEFONO", "TELEFONO"),
                    new cmbEstados("EMAIL", "EMAIL")
                };
        }

        public static cmbEstados[] Clasificacion()
        {
            return new cmbEstados[] {
                    new cmbEstados("GESTION", "GESTION"),
                    new cmbEstados("COMPRA", "COMPRA"),
                    new cmbEstados("VENTA", "VENTA")
                };
        }

        public static cmbEstados[] CategoriaConsumible()
        {
            return new cmbEstados[] {
                    new cmbEstados("PRODUCTO", "PRODUCTO"),
                    new cmbEstados("SERVICIO", "SERVICIO")
                };
        }

        public static cmbEstados[] EstadoExamen()
        {
            return new cmbEstados[] {
                    new cmbEstados("PENDIENTE", "PENDIENTE"),
                    new cmbEstados("ANALIZADO", "ANALIZADO")
                };
        }
    }
}
