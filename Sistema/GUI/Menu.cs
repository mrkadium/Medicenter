using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.GUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            General.GUI.Medicos.GestionMedicos f = new General.GUI.Medicos.GestionMedicos();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            General.GUI.Especialidades.GestionEspecialidades f = new General.GUI.Especialidades.GestionEspecialidades();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            General.GUI.Contactos.GestionContactos f = new General.GUI.Contactos.GestionContactos();
            f.MdiParent = this.MdiParent;
            f.Show();
        }
    }
}
