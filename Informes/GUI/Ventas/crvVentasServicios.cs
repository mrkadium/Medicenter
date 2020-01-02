using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes.GUI.Ventas
{
    public partial class crvVentasServicios : Form
    {
        private void CargarReporte()
        {
            REP.Ventas.crVentasServicios oReporte = new REP.Ventas.crVentasServicios();
            oReporte.SetDataSource(CacheManager.SystemCache.ReporteVentasServicios(Convert.ToDateTime(txbFechaInicio.Text), Convert.ToDateTime(txbFechaFin.Text)));
            crVentasServi.ReportSource = oReporte;
        }

        public crvVentasServicios()
        {
            InitializeComponent();
        }

        private void crvVentasServicios_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
