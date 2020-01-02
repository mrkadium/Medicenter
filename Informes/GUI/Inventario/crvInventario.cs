using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes.GUI.Inventario
{
    public partial class crvInventario : Form
    {
        private void CargarReporte()
        {
            if (txbIdMarca.Text.Length <= 0)
            {
                REP.Inventario.crInventario oReporte = new REP.Inventario.crInventario();
                oReporte.SetDataSource(CacheManager.SystemCache.ReporteInventario());
                crInventa.ReportSource = oReporte;
            }
            else
            {
                REP.Inventario.crInventarioMarcaEspe oReporte = new REP.Inventario.crInventarioMarcaEspe();
                oReporte.SetDataSource(CacheManager.SystemCache.ReporteInventarioMarcaEspeci(Convert.ToInt32(txbIdMarca.Text)));
                crInventa.ReportSource = oReporte;
            }
        }

        public crvInventario()
        {
            InitializeComponent();
        }

        private void crInventa_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
