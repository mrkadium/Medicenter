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
    public partial class crvComprasMarcaEspecifica : Form
    {
        private void CargarReporte()
        {
            REP.Compras.crComprasMarcaEspecifica oReporte = new REP.Compras.crComprasMarcaEspecifica();
            oReporte.SetDataSource(CacheManager.SystemCache.ReporteCompraMarcaEspecifica(Convert.ToInt32(txbIdMarca.Text), Convert.ToDateTime(txbFechaInicio.Text), Convert.ToDateTime(txbFechaFin.Text)));
            crComprasMarca.ReportSource = oReporte;
        }

        public crvComprasMarcaEspecifica()
        {
            InitializeComponent();
        }

        private void crvComprasMarcaEspecifica_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
