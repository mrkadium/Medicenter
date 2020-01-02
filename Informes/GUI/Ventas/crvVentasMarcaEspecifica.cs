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
    public partial class crvVentasMarcaEspecifica : Form
    {
        private void CargarReporte()
        {
            REP.Ventas.crVentasMarcaEspecifica oReporte = new REP.Ventas.crVentasMarcaEspecifica();
            oReporte.SetDataSource(CacheManager.SystemCache.ReporteVentasMarcaEspecifica(Convert.ToInt32(txbIdMarca.Text), Convert.ToDateTime(txbFechaInicio.Text), Convert.ToDateTime(txbFechaFin.Text)));
            crVentasMarca.ReportSource = oReporte;
        }

        public crvVentasMarcaEspecifica()
        {
            InitializeComponent();
        }

        private void crvVentasMarcaEspecifica_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
