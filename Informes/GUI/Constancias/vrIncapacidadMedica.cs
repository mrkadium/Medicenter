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
    public partial class vrIncapacidadMedica : Form
    {
        private void CargarReporte()
        {
            REP.Constancias.IncapacidadMedica oReporte = new REP.Constancias.IncapacidadMedica();
            oReporte.SetDataSource(CacheManager.SystemCache.IncapacidadMedica(txbPaciente.Text, Convert.ToInt32(txbIdPaciente.Text), Convert.ToInt32(txbIncapacidad.Text)));
            crvIncapacidadMedica.ReportSource = oReporte;
        }

        public vrIncapacidadMedica()
        {
            InitializeComponent();        
        }

        private void vrIncapacidadMedica_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
