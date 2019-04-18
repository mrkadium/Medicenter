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
    public partial class GestionUsuariosEmpleados : Form
    {
        BindingSource _UsuariosEmpleados = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _UsuariosEmpleados.DataSource = CacheManager.SystemCache.Todos_usuarios_empleados();
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
                    _UsuariosEmpleados.Filter = "usuario LIKE '%" + txbFiltro.Text + "%' OR empleado LIKE '%" + txbFiltro.Text + "%' OR rol LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _UsuariosEmpleados.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _UsuariosEmpleados;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }
        public GestionUsuariosEmpleados()
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

        private void txbFiltro_TextChanged_1(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
        
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            EdicionUsuarios f = new EdicionUsuarios();
            //DESAPARECIENDO LOS ELEMENTOS PARA MÉDICOS, YA QUE ES EMPLEADO
            f.lblMedico.Visible = false;
            f.txbJVPM.Visible = false;
            f.txbMedico.Visible = false;
            f.btnMedicos.Visible = false;

            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea editar ese registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EdicionUsuarios f = new EdicionUsuarios();
                //DESAPARECIENDO LOS ELEMENTOS PARA MÉDICOS, YA QUE ES EMPLEADO
                f.lblMedico.Visible = false;
                f.txbJVPM.Visible = false;
                f.txbMedico.Visible = false;
                f.btnMedicos.Visible = false;

                f.txbIdUsuario.Text = dtgvDatos.CurrentRow.Cells["IdUsuario"].Value.ToString();
                f.txbUsuario.Text = dtgvDatos.CurrentRow.Cells["Usuario"].Value.ToString();
                f.txbIdEmpleado.Text = dtgvDatos.CurrentRow.Cells["IdEmpleado"].Value.ToString();

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

        private void GestionUsuariosEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
