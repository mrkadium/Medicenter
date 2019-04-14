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
    public partial class GestionUsuarios : Form
    {
        BindingSource _Usuarios = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _Usuarios.DataSource = CacheManager.SystemCache.Todos_usuarios();
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
                    _Usuarios.Filter = "usuario LIKE '%" + txbFiltro.Text + "%' OR empleado LIKE '%" + txbFiltro.Text + "%' OR rol LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Usuarios.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Usuarios;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }
        public GestionUsuarios()
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txbFiltro_TextChanged_1(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        class cmbEstado
        {
            public String Dmember { get; set; }
            public String Vmember { get; set; }
            public cmbEstado(String dmem, String vmem)
            {
                Dmember = dmem;
                Vmember = vmem;
            }
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            EdicionUsuarios f = new EdicionUsuarios();

            //CARGANDO LOS COMBOBOX
            f.cmbRol.DataSource = CacheManager.SystemCache.Todos_roles();
            f.cmbRol.DisplayMember = "Rol";
            f.cmbRol.ValueMember = "IdRol";
            f.cmbEstado.DataSource = new cmbEstado[] {
                new cmbEstado("ACTIVO", "ACTIVO"),
                new cmbEstado("BLOQUEADO", "BLOQUEADO")
            };
            f.cmbEstado.DisplayMember = "Dmember";
            f.cmbEstado.ValueMember = "Vmember";

            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea editar ese registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EdicionUsuarios f = new EdicionUsuarios();

                f.txbIdUsuario.Text = dtgvDatos.CurrentRow.Cells["IdUsuario"].Value.ToString();
                f.txbUsuario.Text = dtgvDatos.CurrentRow.Cells["Usuario"].Value.ToString();
                f.txbIdEmpleado.Text = dtgvDatos.CurrentRow.Cells["IdEmpleado"].Value.ToString();

                //CARGANDO LOS COMBOBOX
                f.cmbRol.DataSource = CacheManager.SystemCache.Todos_roles();
                f.cmbRol.DisplayMember = "Rol";
                f.cmbRol.ValueMember = "IdRol";
                f.cmbEstado.DataSource = new cmbEstado[] {new cmbEstado("ACTIVO", "ACTIVO"),new cmbEstado("BLOQUEADO", "BLOQUEADO")};
                f.cmbEstado.DisplayMember = "Dmember";
                f.cmbEstado.ValueMember = "Vmember";

                f.txbEmpleado.Text = dtgvDatos.CurrentRow.Cells["Empleado"].Value.ToString();
                f.txbCredencial.Text = dtgvDatos.CurrentRow.Cells["Credencial"].Value.ToString();
                f.cmbEstado.SelectedValue = dtgvDatos.CurrentRow.Cells["Estado"].Value.ToString();
                f.cmbRol.SelectedValue = dtgvDatos.CurrentRow.Cells["IdRol"].Value.ToString();

                f.ShowDialog();

                CargarDatos();
            }
        }

        private void dtgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea eliminar ese registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Usuario oUsuario = new CLS.Usuario();
                oUsuario.IDUsuario = dtgvDatos.CurrentRow.Cells["IdUsuario"].Value.ToString();
                if (oUsuario.Eliminar())
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
    }
}
