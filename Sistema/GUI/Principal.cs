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
    public partial class Principal : Form
    {
        SessionManager.Session _SESION = SessionManager.Session.Instancia;
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblEmpleado.Text = _SESION.oUsuario.Empleado;
            lblUsuario.Text = "[" + _SESION.oUsuario.Usuario1 + "]";
        }

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            General.GUI.GestionEmpleados f = new General.GUI.GestionEmpleados();
            f.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.GestionEmpleados f = new General.GUI.GestionEmpleados();
            f.MdiParent = this;
            f.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.GestionUsuariosEmpleados f = new General.GUI.GestionUsuariosEmpleados();
            f.MdiParent = this;
            f.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.GestionMedicos f = new General.GUI.GestionMedicos();
            f.MdiParent = this;
            f.Show();
        }

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            General.GUI.EdicionUsuarios f = new General.GUI.EdicionUsuarios();
            f.ShowDialog();
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.GestionUsuariosMedicos f = new General.GUI.GestionUsuariosMedicos();
            f.MdiParent = this;
            f.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            General.GUI.GestionUsuariosEmpleados f = new General.GUI.GestionUsuariosEmpleados();
            f.MdiParent = this;
            f.Show();
        }
    }
}
