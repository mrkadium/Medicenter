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
    public partial class crvVentasProductos : Form
    {
        private void CargarReporte()
        {
            REP.Ventas.crVentasProductos oReporte = new REP.Ventas.crVentasProductos();
            oReporte.SetDataSource(CacheManager.SystemCache.ReporteVentasProductos(Convert.ToDateTime(txbFechaInicio.Text), Convert.ToDateTime(txbFechaFin.Text)));
            crVentasProduc.ReportSource = oReporte;
        }

        public crvVentasProductos()
        {
            InitializeComponent();
        }

        private void crvVentasProductos_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
