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
    public partial class GestionUsuariosMedicos : Form
    {
        BindingSource _UsuariosMedicos = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _UsuariosMedicos.DataSource = CacheManager.SystemCache.Todos_usuarios_medicos();
                FiltrarLocalmente();
            }
            catch { }
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txbFiltro.TextLength > 0)
                {
                    _UsuariosMedicos.Filter = "usuario LIKE '%" + txbFiltro.Text + "%' OR empleado LIKE '%" + txbFiltro.Text + "%' OR jvpm LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _UsuariosMedicos.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _UsuariosMedicos;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }
        public GestionUsuariosMedicos()
        {
            InitializeComponent();
        }

        private void GestionUsuariosMedicos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionUsuarios f = new EdicionUsuarios();
            f.lblEmpleado.Visible = false;
            f.txbIdEmpleado.Visible = false;
            f.txbEmpleado.Visible = false;
            f.btnEmpleados.Visible = false;

            f.ShowDialog();
            CargarDatos();
        }
    }
}
