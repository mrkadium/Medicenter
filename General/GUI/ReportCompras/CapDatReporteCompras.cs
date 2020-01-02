using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.ReportCompras
{
    public partial class CapDatReporteCompras : Form
    {
        private void Procesar()
        {
            if (Verificacion())
            {
                if (rdbGeneral.Checked == true)
                {
                    if (CacheManager.SystemCache.VerificaReporteCompraProductos(Convert.ToDateTime(dtpFechaInicio.Text), Convert.ToDateTime(dtpFechaFin.Text)))
                    {
                        Informes.GUI.Compras.crvComprasProductos f = new Informes.GUI.Compras.crvComprasProductos();

                        f.txbFechaInicio.Text = dtpFechaInicio.Text;
                        f.txbFechaFin.Text = dtpFechaFin.Text;
                        f.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se escontraron compras en ese período", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (rdbProductoEspe.Checked == true)
                {
                    if (CacheManager.SystemCache.VerificaReporteCompraProductosEspecifico(Convert.ToInt32(txbIdProducto.Text), Convert.ToDateTime(dtpFechaInicio.Text), Convert.ToDateTime(dtpFechaFin.Text)))
                    {
                        Informes.GUI.Compras.crComprasProductosEspecifico f = new Informes.GUI.Compras.crComprasProductosEspecifico();

                        f.txbIdProducto.Text = txbIdProducto.Text;
                        f.txbFechaInicio.Text = dtpFechaInicio.Text;
                        f.txbFechaFin.Text = dtpFechaFin.Text;
                        f.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron compras de " + txbProducto.Text + " en ese período", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (rdbMarcaEspe.Checked == true)
                {
                    if (CacheManager.SystemCache.VerificaReporteCompraMarcaEspecifica(Convert.ToInt32(txbIdMarca.Text), Convert.ToDateTime(dtpFechaInicio.Text), Convert.ToDateTime(dtpFechaFin.Text)))
                    {
                        Informes.GUI.Compras.crvComprasMarcaEspecifica f = new Informes.GUI.Compras.crvComprasMarcaEspecifica();

                        f.txbIdMarca.Text = txbIdMarca.Text;
                        f.txbFechaInicio.Text = dtpFechaInicio.Text;
                        f.txbFechaFin.Text = dtpFechaFin.Text;
                        f.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron compras de " + txbMarca.Text + " en ese período", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private Boolean Verificacion()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (rdbGeneral.Checked == false && rdbProductoEspe.Checked == false && rdbMarcaEspe.Checked == false)
            {
                Notificador.SetError(gpbTipoCompra, "Seleccione un una opción");
            }
            else if (rdbProductoEspe.Checked == true)
            {
                if (txbProducto.TextLength <= 0) { Verificado = false; Notificador.SetError(btnProducto, "Seleccione un producto"); }
            }
            else if (rdbMarcaEspe.Checked == true)
            {
                if (txbIdMarca.TextLength <= 0) { Verificado = false; Notificador.SetError(btnMarca, "Seleccione un producto"); }
            }

            return Verificado;
        }

        public CapDatReporteCompras()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            GUI.Consumibles.GestionConsumibles f = new GUI.Consumibles.GestionConsumibles();
            AddOwnedForm(f);
            f.Todos = false;
            f.SoloConsultas = false;
            f.TipoOperacion = 1;
            f.btnAgregar.Visible = false;
            f.btnEditar.Visible = false;
            f.btnEliminar.Visible = false;
            f.btnSeleccionar.Visible = true;
            f.ShowDialog();
        }

        private void btnProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                GUI.Consumibles.GestionConsumibles f = new GUI.Consumibles.GestionConsumibles();
                AddOwnedForm(f);
                f.Todos = false;
                f.SoloConsultas = false;
                f.TipoOperacion = 1;
                f.btnAgregar.Visible = false;
                f.btnEditar.Visible = false;
                f.btnEliminar.Visible = false;
                f.btnSeleccionar.Visible = true;
                f.ShowDialog();
            }
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            GUI.Marcas.GestionMarcas f = new GUI.Marcas.GestionMarcas();
            AddOwnedForm(f);
            f.btnAgregar.Visible = false;
            f.btnEditar.Visible = false;
            f.btnEliminar.Visible = false;
            f.btnSeleccionar.Visible = true;
            f.TipoOperacion = 2;
            f.ShowDialog();
        }

        private void btnMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                GUI.Marcas.GestionMarcas f = new GUI.Marcas.GestionMarcas();
                AddOwnedForm(f);
                f.btnAgregar.Visible = false;
                f.btnEditar.Visible = false;
                f.btnEliminar.Visible = false;
                f.btnSeleccionar.Visible = true;
                f.TipoOperacion = 2;
                f.ShowDialog();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnGenerar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Close();
            }
        }

        private void rdbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGeneral.Checked == true)
            {
                txbIdProducto.Clear();
                txbProducto.Clear();
                txbIdMarca.Clear();
                txbMarca.Clear();
                btnProducto.Enabled = false;
                btnMarca.Enabled = false;
            }
        }

        private void rdbProductoEspe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProductoEspe.Checked == true)
            {
                txbIdMarca.Clear();
                txbMarca.Clear();
                btnProducto.Enabled = true;
                btnMarca.Enabled = false;
            }
        }

        private void rdbMarcaEspe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMarcaEspe.Checked == true)
            {
                txbIdProducto.Clear();
                txbProducto.Clear();
                btnProducto.Enabled = false;
                btnMarca.Enabled = true;
            }
        }
    }
}
