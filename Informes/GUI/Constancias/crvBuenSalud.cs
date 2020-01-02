using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes.GUI.Constancias
{
    public partial class crvBuenSalud : Form
    {
        private void CargarReporte()
        {
            REP.Constancias.BuenaSalud oReporte = new REP.Constancias.BuenaSalud();
            oReporte.SetDataSource(CacheManager.SystemCache.EdadPaciente(txbPaciente.Text, Convert.ToInt32(txbidMedico.Text), Convert.ToInt32(txbIdPaciente.Text)));
            crvBuenaSalud.ReportSource = oReporte;
        }

        public crvBuenSalud()
        {
            InitializeComponent();
        }

        private void crvBuenSalud_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
