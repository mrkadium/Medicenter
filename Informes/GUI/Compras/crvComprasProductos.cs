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
    public partial class crvComprasProductos : Form
    {
        private void CargarReporte()
        {
            REP.Compras.crComprasProductos oReporte = new REP.Compras.crComprasProductos();
            oReporte.SetDataSource(CacheManager.SystemCache.ReporteCompraProductos(Convert.ToDateTime(txbFechaInicio.Text), Convert.ToDateTime(txbFechaFin.Text)));
            crComprasProduc.ReportSource = oReporte;
        }

        public crvComprasProductos()
        {
            InitializeComponent();
        }

        private void crvComprasProductos_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
