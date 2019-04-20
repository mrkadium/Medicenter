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


        public static cmbEstados[] Estados()
        {
            return new cmbEstados[] {
                    new cmbEstados("ACTIVO", "ACTIVO"),
                    new cmbEstados("INACTIVO", "INACTIVO")
                };
        }

        public static cmbEstados[] Generos()
        {
            return new cmbEstados[] {
                    new cmbEstados("FEMENINO", "FEMENINO"),
                    new cmbEstados("MASCULINO", "MASCULINO")
                };
        }
    }
}
