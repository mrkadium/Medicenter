using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Opciones
{
    public partial class GestionOpciones : Form
    {
        BindingSource _Opciones = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _Opciones.DataSource = CacheManager.SystemCache.TodasOpciones();
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
                    _Opciones.Filter = "opcion LIKE '%" + txbFiltro.Text + "%' OR clasificacion LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Opciones.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Opciones;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }

        public GestionOpciones()
        {
            InitializeComponent();
        }

        SessionManager.Session _Sesion = SessionManager.Session.Instancia;

        private void GestionOpciones_Load(object sender, EventArgs e)
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
            EdicionOpciones f = new EdicionOpciones();
            f.lblID.Visible = false;
            f.txbIdOpcion.Visible = false;
            f.lblOpcion.Margin = new Padding(3, 27, 3, 0);
            f.txbOpcion.Margin = new Padding(3, 8, 3, 15);
            f.lblClasificacion.Margin = new Padding(3, 10, 3, 0);
            f.cmbClasificacion.Margin = new Padding(3, 8, 3, 0);
            f.btnAgregar.Location = new Point(63, 214);
            f.btnCancelar.Location = new Point(183, 214);
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
                    EdicionOpciones f = new EdicionOpciones();

                    //Sincronizando interfaz gráfica con registro seleccionado
                    //(Muestra los datos del registro a editar)
                    f.txbIdOpcion.Text = dtgvDatos.CurrentRow.Cells["idopcion"].Value.ToString();
                    f.txbOpcion.Text = dtgvDatos.CurrentRow.Cells["opcion"].Value.ToString();
                    f.cmbClasificacion.SelectedValue = dtgvDatos.CurrentRow.Cells["clasificacion"].Value.ToString();
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
                    CLS.Opciones oOpciones = new CLS.Opciones();
                    oOpciones.Idopcion = Convert.ToInt32(dtgvDatos.CurrentRow.Cells["idopcion"].Value.ToString());
                    if (oOpciones.Eliminar())
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
