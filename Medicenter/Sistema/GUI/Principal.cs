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
            lblUsuario.Text = _SESION.oUsuario.Usuario1;
        }

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            General.GUI.GestionEmpleados f = new General.GUI.GestionEmpleados();
            f.Show();
        }
    }
}
