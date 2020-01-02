using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Roles
{
    public partial class GestionRoles : Form
    {
        BindingSource _Roles = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _Roles.DataSource = CacheManager.SystemCache.TodosRoles();
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

        private void GestionRoles_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionRoles f = new EdicionRoles();
            f.lblID.Visible = false;
            f.txbIdRol.Visible = false;
            f.lblRol.Margin = new Padding(3, 29, 3, 0);
            f.txbRol.Margin = new Padding(3, 8, 3, 15);
            f.btnAgregar.Location = new Point(56, 136);
            f.btnCancelar.Location = new Point(176, 136);
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dtgvDatos.Rows.Count.ToString()) <= 0)
            {
                MessageBox.Show("Actualmente no existe ningún registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EdicionRoles f = new EdicionRoles();

                    //Sincronizando interfaz gráfica con registro seleccionado
                    //(Muestra los datos del registro a editar)
                    f.txbIdRol.Text = dtgvDatos.CurrentRow.Cells["idrol"].Value.ToString();
                    f.txbRol.Text = dtgvDatos.CurrentRow.Cells["rol"].Value.ToString();
                    f.ShowDialog();
                    CargarDatos();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dtgvDatos.Rows.Count.ToString()) <= 0)
            {
                MessageBox.Show("Actualmente no existe ningún registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Roles oRoles = new CLS.Roles();
                    oRoles.Idrol = Convert.ToInt32(dtgvDatos.CurrentRow.Cells["idrol"].Value.ToString());
                    if (oRoles.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado exitosamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("El registro no pudo ser eliminado correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
