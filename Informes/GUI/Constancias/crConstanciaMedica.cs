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
    public partial class crConstanciaMedica : Form
    {
        private void CargarReporte()
        {
            REP.Constancias.ConstanciaMedica oReporte = new REP.Constancias.ConstanciaMedica();
            oReporte.SetDataSource(CacheManager.SystemCache.IncapacidadMedica(txbPaciente.Text, Convert.ToInt32(txbIdPaciente.Text), 0));
            crvConstanciaMedica.ReportSource = oReporte;
        }

        public crConstanciaMedica()
        {
            InitializeComponent();
        }

        private void crConstanciaMedica_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
