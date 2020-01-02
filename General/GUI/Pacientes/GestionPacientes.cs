using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Pacientes
{
    public partial class GestionPacientes : Form
    {
        BindingSource _Pacientes = new BindingSource();
        bool Incapacidad = true;

        public bool Incapacidad1 { get => Incapacidad; set => Incapacidad = value; }

        private void CargarDatos()
        {
            try
            {
                _Pacientes.DataSource = CacheManager.SystemCache.TodosPacientes();
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
                    _Pacientes.Filter = "nombres LIKE '%" + txbFiltro.Text + "%' OR apellidos LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Pacientes.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Pacientes;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }

        public GestionPacientes()
        {
            InitializeComponent();
        }

        SessionManager.Session _Sesion = SessionManager.Session.Instancia;

        private void GestionPacientes_Load(object sender, EventArgs e)
        {
            CargarDatos();

            if (!_Sesion.oUsuario.verificarPermiso("AGREGAR"))
            {
                btnAgregar.Visible = false;
            }
            if (!_Sesion.oUsuario.verificarPermiso("EDITAR"))
            {
                btnEditar.Visible = false;
            }
            if (!_Sesion.oUsuario.verificarPermiso("ELIMINAR"))
            {
                btnEliminar.Visible = false;
            }
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (Incapacidad)
            {
                GUI.Constancias.CapDatIncapacidad f = Owner as GUI.Constancias.CapDatIncapacidad;
                f.txbIdPaciente.Text = dtgvDatos.CurrentRow.Cells["idpaciente"].Value.ToString();
                f.txbPaciente.Text = dtgvDatos.CurrentRow.Cells["nombres"].Value.ToString() + " " + dtgvDatos.CurrentRow.Cells["apellidos"].Value.ToString();
            }

            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionPacientes f = new EdicionPacientes();
            f.lblID.Visible = false;
            f.txbIDMedico.Visible = false;
            f.lblExpediente.Margin = new Padding(0, 0, 0, 0);
            f.lblGenero.Margin = new Padding(3, 15, 0, 0);
            f.cmbGenero.Margin = new Padding(3, 5, 0, 0);
            f.lblTelefono.Margin = new Padding(40, 0, 0, 0);
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
                    EdicionPacientes f = new EdicionPacientes();

                    //Sincronizando interfaz gráfica con registro seleccionado
                    //(Muestra los datos del registro a editar)
                    f.txbIDMedico.Text = dtgvDatos.CurrentRow.Cells["idpaciente"].Value.ToString();
                    f.txbExpediente.Text = dtgvDatos.CurrentRow.Cells["expediente"].Value.ToString();
                    f.txbNombres.Text = dtgvDatos.CurrentRow.Cells["nombres"].Value.ToString();
                    f.txbApellidos.Text = dtgvDatos.CurrentRow.Cells["apellidos"].Value.ToString();
                    f.dtpFechaNacimiento.Text = dtgvDatos.CurrentRow.Cells["fecha_nacimiento"].Value.ToString();
                    f.cmbGenero.SelectedValue = dtgvDatos.CurrentRow.Cells["genero"].Value.ToString();
                    f.txbTelefono.Text = dtgvDatos.CurrentRow.Cells["telefono"].Value.ToString();
                    f.txbEmail.Text = dtgvDatos.CurrentRow.Cells["email"].Value.ToString();
                    f.txbMunicipio.Text = dtgvDatos.CurrentRow.Cells["municipio"].Value.ToString();
                    f.cmbDepartamento.SelectedValue = dtgvDatos.CurrentRow.Cells["iddepartamento"].Value.ToString();
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
                    CLS.Pacientes oPacientes = new CLS.Pacientes();
                    oPacientes.Idpaciente = Convert.ToInt32(dtgvDatos.CurrentRow.Cells["idpaciente"].Value.ToString());
                    if (oPacientes.Eliminar())
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
