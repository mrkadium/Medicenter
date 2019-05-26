using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace General.CLS
{
    public class cmbEstados : Form
    {
        public String Dmember { get; set; }
        public String Vmember { get; set; }
        public cmbEstados(String dmem, String vmem)
        {
            Dmember = dmem;
            Vmember = vmem;
        }


        public static cmbEstados[] estados()
        {
            return new cmbEstados[] {
                    new cmbEstados("ACTIVO", "INACTIVO"),
                    new cmbEstados("INACTIVO", "INACTIVO")
                };
        }

        public static cmbEstados[] generos()
        {
            return new cmbEstados[] {
                    new cmbEstados("FEMENINO", "FEMENINO"),
                    new cmbEstados("MASCULINO", "MASCULINO")
                };
        }
    }
}
