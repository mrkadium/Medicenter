using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Especialidades
{
    public partial class GestionEspecialidades : Form
    {
        BindingSource _Especialidades = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _Especialidades.DataSource = CacheManager.SystemCache.TodasEspecialidades();
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
                    _Especialidades.Filter = "especialidad LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Especialidades.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Especialidades;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }

        public GestionEspecialidades()
        {
            InitializeComponent();
        }

        SessionManager.Session _Sesion = SessionManager.Session.Instancia;

        private void GestionEspecialidades_Load(object sender, EventArgs e)
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
            Medicos.EdicionMedicos f = Owner as Medicos.EdicionMedicos;
            DataRow row = f._Especialidades.NewRow();
            
            row["idespecialidad"] = dtgvDatos.CurrentRow.Cells["idespecialidad"].Value.ToString();
            row["especialidad"] = dtgvDatos.CurrentRow.Cells["especialidad"].Value.ToString();
            f._Especialidades.Rows.Add(row);

            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionEspecialidades f = new EdicionEspecialidades();
            f.lblID.Visible = false;
            f.txbIDEspecialidad.Visible = false;
            f.lblEspecialidad.Margin = new Padding(3, 25, 3, 0);
            f.txbEspecialidad.Margin = new Padding(3, 15, 3, 15);
            f.btnAgregar.Location = new Point(54, 146);
            f.btnCancelar.Location = new Point(174, 146);
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
                    EdicionEspecialidades f = new EdicionEspecialidades();

                    //Sincronizando interfaz gráfica con registro seleccionado
                    //(Muestra los datos del registro a editar)
                    f.txbIDEspecialidad.Text = dtgvDatos.CurrentRow.Cells["idespecialidad"].Value.ToString();
                    f.txbEspecialidad.Text = dtgvDatos.CurrentRow.Cells["especialidad"].Value.ToString();
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
                    CLS.Especialidades oEspecialidad = new CLS.Especialidades();
                    oEspecialidad.Idespecialidad = Convert.ToInt32(dtgvDatos.CurrentRow.Cells["idespecialidad"].Value.ToString());
                    if (oEspecialidad.Eliminar())
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

        private void dtgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
