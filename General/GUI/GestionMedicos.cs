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
    public partial class GestionMedicos : Form
    {
        BindingSource _Medicos = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _Medicos.DataSource = CacheManager.SystemCache.Todos_medicos();
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
                    _Medicos.Filter = "nombres LIKE '%" + txbFiltro.Text + "%' OR apellidos LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Medicos.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Medicos;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }
        public GestionMedicos()
        {
            InitializeComponent();
        }

        private void GestionMedicos_Load(object sender, EventArgs e)
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
            EdicionMedico f = new EdicionMedico();
            f.dtpContratacion.Text = null;
            f.dtpSalida.Text = null;
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EdicionMedico f = new EdicionMedico();

                //Sincronizando interfaz gráfica con registro seleccionado
                //(Muestra los datos del registro a editar)
                f.txbIDMedico.Text = dtgvDatos.CurrentRow.Cells["idmedico"].Value.ToString();
                f.txbJVPM.Text = dtgvDatos.CurrentRow.Cells["jvpm"].Value.ToString();
                f.txbNombres.Text = dtgvDatos.CurrentRow.Cells["nombres"].Value.ToString();
                f.txbApellidos.Text = dtgvDatos.CurrentRow.Cells["apellidos"].Value.ToString();
                f.cmbGenero.SelectedValue = dtgvDatos.CurrentRow.Cells["genero"].Value.ToString();
                f.dtpFechaNacimiento.Text = dtgvDatos.CurrentRow.Cells["fecha_nacimiento"].Value.ToString();
                f.txbMunicipio.Text = dtgvDatos.CurrentRow.Cells["municipio"].Value.ToString();
                f.txbDireccion.Text = dtgvDatos.CurrentRow.Cells["Direcc"].Value.ToString();
                f.txbDui.Text = dtgvDatos.CurrentRow.Cells["dui"].Value.ToString();
                f.txbNit.Text = dtgvDatos.CurrentRow.Cells["nit"].Value.ToString();
                f.dtpContratacion.Text = dtgvDatos.CurrentRow.Cells["contratacion"].Value.ToString();
                f.dtpSalida.Text = dtgvDatos.CurrentRow.Cells["salida"].Value.ToString();
                f.cmbEstado.SelectedValue = dtgvDatos.CurrentRow.Cells["estado"].Value.ToString();
                f.cmbDepartamento.SelectedValue = dtgvDatos.CurrentRow.Cells["iddepartamento"].Value.ToString();
                f.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Medico oMedico = new CLS.Medico();
                oMedico.Idmedico = dtgvDatos.CurrentRow.Cells["idmedico"].Value.ToString();
                if (oMedico.Eliminar())
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
