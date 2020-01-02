using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes.GUI
{
    public partial class crVentas : Form
    {
        private void CargarReporte()
        {
            REP.Ventas.crVentas oReporte = new REP.Ventas.crVentas();
            oReporte.SetDataSource(CacheManager.SystemCache.ReporteVentasGeneral(Convert.ToDateTime(txbFechaInicio.Text), Convert.ToDateTime(txbFechaFin.Text)));
            crvVentas.ReportSource = oReporte;
        }

        public crVentas()
        {
            InitializeComponent();
        }

        private void crVentas_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
