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
    public partial class DetalleVenta : Form
    {
        int _IDOperacion;

        public DetalleVenta()
        {
            InitializeComponent();
        }

        public int IDOperacion { get => _IDOperacion; set => _IDOperacion = value; }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            dtgvDatosProducto.AutoGenerateColumns = false;
            dtgvDatosProducto.DataSource = CacheManager.SystemCache.DetalleCompra(IDOperacion);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
