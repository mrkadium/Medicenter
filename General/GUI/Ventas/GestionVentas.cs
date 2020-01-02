using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Ventas
{
    public partial class GestionVentas : Form
    {
        BindingSource _Ventas = new BindingSource();

        private void CargarVentas()
        {
            try
            {
                _Ventas.DataSource = CacheManager.SystemCache.TodasVentas();
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
                    _Ventas.Filter = "titular LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Ventas.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Ventas;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }

        public GestionVentas()
        {
            InitializeComponent();
        }

        private void GestionVentas_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnRegVenta_Click(object sender, EventArgs e)
        {
            EdicionVenta f = new EdicionVenta();
            f.ShowDialog();
            CargarVentas();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            DetalleVenta f = new DetalleVenta();
            f.txbIdOperacion.Text = dtgvDatos.CurrentRow.Cells["idoperacion"].Value.ToString();
            f.IDOperacion = int.Parse(dtgvDatos.CurrentRow.Cells["idoperacion"].Value.ToString());
            f.txbIdTitular.Text = dtgvDatos.CurrentRow.Cells["idtitular"].Value.ToString();
            f.txbTitular.Text = dtgvDatos.CurrentRow.Cells["titular"].Value.ToString();
            f.dtpFechaCompra.Text = dtgvDatos.CurrentRow.Cells["fecha"].Value.ToString();
            f.txbTotal.Text = dtgvDatos.CurrentRow.Cells["total_venta"].Value.ToString();
            f.Show();
        }
    }
}
