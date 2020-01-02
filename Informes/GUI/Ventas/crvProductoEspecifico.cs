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
    public partial class crvProductoEspecifico : Form
    {
        private void CargarReporte()
        {
            REP.Ventas.crVentasProductoEspecifico oReporte = new REP.Ventas.crVentasProductoEspecifico();
            oReporte.SetDataSource(CacheManager.SystemCache.ReporteVentasProductosEspecifico(Convert.ToInt32(txbIdProducto.Text), Convert.ToDateTime(txbFechaInicio.Text), Convert.ToDateTime(txbFechaFin.Text)));
            crVentasProduc.ReportSource = oReporte;
        }

        public crvProductoEspecifico()
        {
            InitializeComponent();
        }

        private void crvProductoEspecifico_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
