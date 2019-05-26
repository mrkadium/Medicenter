using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class EdicionMedico : Form
    {
        public EdicionMedico()
        {
            InitializeComponent();
        }

        private void EdicionMedico_Load(object sender, EventArgs e)
        {
            txbNombres.Focus();
        }
    }
}
