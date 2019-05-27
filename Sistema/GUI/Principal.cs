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

            Menu f = new Menu();
            f.WindowState = FormWindowState.Maximized;
            f.MdiParent = this;
            f.Show();
        }
        
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
        }
        
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == this.GetType() && frm != this)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.WindowState = FormWindowState.Maximized;
            f.MdiParent = this;
            f.Show();
        }
    }
}
