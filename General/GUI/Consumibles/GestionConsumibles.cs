using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Consumibles
{
    public partial class GestionConsumibles : Form
    {
        bool _Todos;
        bool _SoloConsultas;
        int _TipoOperacion;
        bool _Seleccionar = false;
        BindingSource _Consumibles = new BindingSource();

        public bool Todos { get => _Todos; set => _Todos = value; }
        public bool SoloConsultas { get => _SoloConsultas; set => _SoloConsultas = value; }
        public int TipoOperacion { get => _TipoOperacion; set => _TipoOperacion = value; }
        public bool Seleccionar { get => _Seleccionar; set => _Seleccionar = value; }

        private void CargarDatos()
        {
            try
            {
                if (_Todos)
                {
                    _Consumibles.DataSource = CacheManager.SystemCache.TodosConsumibles();
                }
                else if (!_Todos && !_SoloConsultas)
                {
                    _Consumibles.DataSource = CacheManager.SystemCache.SoloProductos();
                }
                else
                {
                    _Consumibles.DataSource = CacheManager.SystemCache.SoloConsultas();
                }
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
                    _Consumibles.Filter = "nombre LIKE '%" + txbFiltro.Text + "%' OR categoria LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Consumibles.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Consumibles;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }

        public GestionConsumibles()
        {
            InitializeComponent();
        }

        SessionManager.Session _Sesion = SessionManager.Session.Instancia;

        private void GestionConsumibles_Load(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Consumibles.EdicionConsumibles f = new EdicionConsumibles();
            f.ShowDialog();
            CargarDatos();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dtgvDatos.CurrentRow;
            EdicionConsumibles f = new EdicionConsumibles();
            f.txbIdConsumile.Text = r.Cells["idconsumible"].Value.ToString();
            f.cmbCategoria.Text = r.Cells["categoria"].Value.ToString();
            f.txbNombre.Text = r.Cells["nombre"].Value.ToString();
            f.txbAlias.Text = r.Cells["alias"].Value.ToString();
            f.txbIdMarca.Text = r.Cells["idmarca"].Value.ToString();
            f.txbMarca.Text = r.Cells["marca"].Value.ToString();
            f.txbPrecioCompra.Text = CLS.cmbEstados.ConvertToDot(r.Cells["preciocompra"].Value.ToString());
            f.txbPrecioVenta.Text = CLS.cmbEstados.ConvertToDot(r.Cells["precioventa"].Value.ToString());
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Consumible oComsumible = new CLS.Consumible();
                oComsumible.IDConsumible = int.Parse(dtgvDatos.CurrentRow.Cells["idconsumible"].Value.ToString());
                if (oComsumible.Eliminar())
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
            if (Seleccionar)
            {
                if (TipoOperacion == 0)
                {
                    ReportVentas.CapDatReporteVentas f = Owner as ReportVentas.CapDatReporteVentas;

                    f.txbIdProducto.Text = dtgvDatos.CurrentRow.Cells["idconsumible"].Value.ToString();
                    f.txbProducto.Text = dtgvDatos.CurrentRow.Cells["nombre"].Value.ToString();

                    Close();
                }
                else if (TipoOperacion == 1)
                {
                    ReportCompras.CapDatReporteCompras f = Owner as ReportCompras.CapDatReporteCompras;

                    f.txbIdProducto.Text = dtgvDatos.CurrentRow.Cells["idconsumible"].Value.ToString();
                    f.txbProducto.Text = dtgvDatos.CurrentRow.Cells["nombre"].Value.ToString();

                    Close();
                }
            }
            Close();
        }
    }
}
