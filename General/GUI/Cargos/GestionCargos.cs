using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Cargos
{
    public partial class GestionCargos : Form
    {
        BindingSource _Cargos = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _Cargos.DataSource = CacheManager.SystemCache.TodosCargos();
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
                    _Cargos.Filter = "cargo LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Cargos.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Cargos;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }

        public GestionCargos()
        {
            InitializeComponent();
        }

        SessionManager.Session _Sesion = SessionManager.Session.Instancia;

        private void GestionCargos_Load(object sender, EventArgs e)
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
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionCargos f = new EdicionCargos();
            f.lblID.Visible = false;
            f.txbIdCargo.Visible = false;
            f.lblCargo.Margin = new Padding(3, 30, 0, 0);
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
                    EdicionCargos f = new EdicionCargos();

                    //Sincronizando interfaz gráfica con registro seleccionado
                    //(Muestra los datos del registro a editar)
                    f.txbIdCargo.Text = dtgvDatos.CurrentRow.Cells["idcargo"].Value.ToString();
                    f.txbCargo.Text = dtgvDatos.CurrentRow.Cells["cargo"].Value.ToString();
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
                    CLS.Cargos oCargos = new CLS.Cargos();
                    oCargos.Idcargo = Convert.ToInt32(dtgvDatos.CurrentRow.Cells["idcargo"].Value.ToString());
                    if (oCargos.Eliminar())
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
