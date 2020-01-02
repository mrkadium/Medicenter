using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Proveedores
{
    public partial class GestionProveedores : Form
    {
        BindingSource _Proveedores = new BindingSource();

        private void CargarProveedores()
        {
            try
            {
                _Proveedores.DataSource = CacheManager.SystemCache.TodosProveedores();
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
                    _Proveedores.Filter = "proveedor LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Proveedores.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Proveedores;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }

        public GestionProveedores()
        {
            InitializeComponent();
        }

        private void GestionProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionProveedor f = new EdicionProveedor();
            f.ShowDialog();
            CargarProveedores();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EdicionProveedor f = new EdicionProveedor();
            f.txbIdLaboratorio.Text = dtgvDatos.CurrentRow.Cells["idlaboratorio"].Value.ToString();
            f.txbNombre.Text = dtgvDatos.CurrentRow.Cells["nombre"].Value.ToString();
            f.txbDescripcion.Text = dtgvDatos.CurrentRow.Cells["descripcion"].Value.ToString();
            f.txbMunicipio.Text = dtgvDatos.CurrentRow.Cells["municipio"].Value.ToString();
            f.cmbDeptos.SelectedValue = dtgvDatos.CurrentRow.Cells["iddepartamento"].Value.ToString();
            f.ShowDialog();
            CargarProveedores();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Laboratorio oLaboratorio = new CLS.Laboratorio();
                oLaboratorio.ID = int.Parse(dtgvDatos.CurrentRow.Cells["idlaboratorio"].Value.ToString());
                if (oLaboratorio.Eliminar())
                {
                    MessageBox.Show("Registro eliminado exitosamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProveedores();
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser eliminado exitosamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
    }
}
