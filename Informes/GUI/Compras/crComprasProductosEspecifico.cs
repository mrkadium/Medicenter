using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes.GUI.Compras
{
    public partial class crComprasProductosEspecifico : Form
    {
        private void CargarReporte()
        {
            REP.Compras.crComprasProductoEspecifico oReporte = new REP.Compras.crComprasProductoEspecifico();
            oReporte.SetDataSource(CacheManager.SystemCache.ReporteCompraProductosEspecifico(Convert.ToInt32(txbIdProducto.Text), Convert.ToDateTime(txbFechaInicio.Text), Convert.ToDateTime(txbFechaFin.Text)));
            crComprasProduc.ReportSource = oReporte;
        }

        public crComprasProductosEspecifico()
        {
            InitializeComponent();
        }

        private void crComprasProductosEspecifico_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
