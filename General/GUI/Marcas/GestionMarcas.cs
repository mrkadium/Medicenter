using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Marcas
{
    public partial class GestionMarcas : Form
    {
        int _TipoOperacion;
        BindingSource _Marcas = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _Marcas.DataSource = CacheManager.SystemCache.TodasMarcas();
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
                    _Marcas.Filter = "marca LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Marcas.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Marcas;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }

        public GestionMarcas()
        {
            InitializeComponent();
        }

        SessionManager.Session _Sesion = SessionManager.Session.Instancia;

        public int TipoOperacion { get => _TipoOperacion; set => _TipoOperacion = value; }

        private void GestionMarcas_Load(object sender, EventArgs e)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EdicionMarca f = new EdicionMarca();
            f.txbIdMarca.Text = dtgvDatos.CurrentRow.Cells["idmarca"].Value.ToString();
            f.txbMarc.Text = dtgvDatos.CurrentRow.Cells["marca"].Value.ToString();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionMarca f = new EdicionMarca();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Marca oMarca = new CLS.Marca();
                oMarca.IDMarca = int.Parse(dtgvDatos.CurrentRow.Cells["idmarca"].Value.ToString());
                if (oMarca.Eliminar())
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (TipoOperacion == 0)
            {
                ReportVentas.CapDatReporteVentas f = Owner as ReportVentas.CapDatReporteVentas;

                f.txbIdMarca.Text = dtgvDatos.CurrentRow.Cells["idmarca"].Value.ToString();
                f.txbMarca.Text = dtgvDatos.CurrentRow.Cells["marca"].Value.ToString();

                Close();
            }
            else if (TipoOperacion == 1)
            {
                ReportInventario.CapDatInventarios f = Owner as ReportInventario.CapDatInventarios;

                f.txbIdMarca.Text = dtgvDatos.CurrentRow.Cells["idmarca"].Value.ToString();
                f.txbMarca.Text = dtgvDatos.CurrentRow.Cells["marca"].Value.ToString();

                Close();
            }
            else if (TipoOperacion == 2)
            {
                ReportCompras.CapDatReporteCompras f = Owner as ReportCompras.CapDatReporteCompras;

                f.txbIdMarca.Text = dtgvDatos.CurrentRow.Cells["idmarca"].Value.ToString();
                f.txbMarca.Text = dtgvDatos.CurrentRow.Cells["marca"].Value.ToString();

                Close();
            }
        }
    }
}
