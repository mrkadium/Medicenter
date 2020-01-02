using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Compras
{
    public partial class GestionCompras : Form
    {
        BindingSource _Compras = new BindingSource();

        public String ConvertToDot(String number)
        {
            String nuevo = "";
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i].ToString().Equals(","))
                {
                    nuevo += ".";
                }
                else
                {
                    nuevo += number[i];
                }
            }
            return nuevo;
        }

        private void CargarCompras()
        {
            try
            {
                _Compras.DataSource = CacheManager.SystemCache.TodasCompras();
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
                    _Compras.Filter = "proveedor LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Compras.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Compras;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }

        public GestionCompras()
        {
            InitializeComponent();
        }

        SessionManager.Session _Sesion = SessionManager.Session.Instancia;

        private void GestionCompras_Load(object sender, EventArgs e)
        {
            CargarCompras();

            if (!_Sesion.oUsuario.verificarPermiso("AGREGAR"))
            {
                btnRegConsulta.Visible = false;
            }
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnRegConsulta_Click(object sender, EventArgs e)
        {
            EdicionCompra f = new EdicionCompra();
            f.ShowDialog();
            CargarCompras();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            DetalleCompra f = new DetalleCompra();
            f.txbIdOperacion.Text = dtgvDatos.CurrentRow.Cells["idoperacion"].Value.ToString();
            f.txbIdProveedor.Text = dtgvDatos.CurrentRow.Cells["idproveedor"].Value.ToString();
            f.txbProveedor.Text = dtgvDatos.CurrentRow.Cells["proveedor"].Value.ToString();
            f.IDOperacion = int.Parse(dtgvDatos.CurrentRow.Cells["idoperacion"].Value.ToString());
            f.dtpFechaCompra.Text = dtgvDatos.CurrentRow.Cells["fecha"].Value.ToString();
            f.txbTotal.Text = ConvertToDot(dtgvDatos.CurrentRow.Cells["total_compra"].Value.ToString());
            f.Show();
        }
    }
}
