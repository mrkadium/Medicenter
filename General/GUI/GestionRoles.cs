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
    public partial class GestionRoles : Form
    {
        BindingSource _Roles = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _Roles.DataSource = CacheManager.SystemCache.Todos_roles();
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
                    _Roles.Filter = "rol LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Roles.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Roles;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }
        public GestionRoles()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionEmpleados f = new EdicionEmpleados();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show("¿Realmente desea editar ese registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EdicionRoles f = new EdicionRoles();

                f.txbIdRol.Text = dtgvDatos.CurrentRow.Cells["IdRol"].Value.ToString();
                f.txbRol.Text = dtgvDatos.CurrentRow.Cells["Rol"].Value.ToString();

                f.ShowDialog();

                CargarDatos();
            }*/
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea eliminar ese registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Empleado oEmpleado = new CLS.Empleado();
                oEmpleado.IDEmpleado = dtgvDatos.CurrentRow.Cells["IdRol"].Value.ToString();
                if (oEmpleado.Eliminar())
                {
                    MessageBox.Show("Borrado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Registro no borrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txbFiltro_TextChanged_1(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void GestionRoles_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
