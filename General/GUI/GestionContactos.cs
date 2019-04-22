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
    public partial class GestionContactos : Form
    {
        BindingSource _Contactos = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _Contactos.DataSource = CacheManager.SystemCache.Todos_Contactos();
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
                    _Contactos.Filter = "propietario LIKE '%" + txbFiltro.Text + "%' OR para LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Contactos.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Contactos;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }

        public GestionContactos()
        {
            InitializeComponent();
        }

        private void GestionContactos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionContactos f = new EdicionContactos();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EdicionContactos f = new EdicionContactos();

                //Sincronizando interfaz gráfica con registro seleccionado
                //(Muestra los datos del registro a editar)
                if (dtgvDatos.CurrentRow.Cells["para"].Value.ToString() == "EMPLEADO")
                {
                    f.rdbEmpleado.Checked = true;
                }
                else
                {
                    f.rdbMedico.Checked = true;
                }
                f.txbIDContacto.Text = dtgvDatos.CurrentRow.Cells["idcontacto"].Value.ToString();
                f.txbPropietario.Text = dtgvDatos.CurrentRow.Cells["propietario"].Value.ToString();
                f.cmbTipo.Text = dtgvDatos.CurrentRow.Cells["tipo"].Value.ToString();
                f.txbContacto.Text = dtgvDatos.CurrentRow.Cells["contacto"].Value.ToString();
                f.lblIDPropietario.Text = dtgvDatos.CurrentRow.Cells["idpropietario"].Value.ToString();
                f.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Contacto oContacto = new CLS.Contacto();
                oContacto.IDContacto = dtgvDatos.CurrentRow.Cells["idcontacto"].Value.ToString();
                if (oContacto.Eliminar())
                {
                    MessageBox.Show("Registro eliminado exitosamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser eliminado exitosamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
