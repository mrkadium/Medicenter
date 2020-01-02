using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.ReportVentas
{
    public partial class CapDatReporteVentas : Form
    {
        private void Procesar()
        {
            if (Verificacion())
            {
                if (rdbGeneral.Checked == true)
                {
                    if (CacheManager.SystemCache.VerificaReporteVentasGeneral(Convert.ToDateTime(dtpFechaInicio.Text), Convert.ToDateTime(dtpFechaFin.Text)))
                    {
                        Informes.GUI.crVentas f = new Informes.GUI.crVentas();

                        f.txbFechaInicio.Text = dtpFechaInicio.Text;
                        f.txbFechaFin.Text = dtpFechaFin.Text;
                        f.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se escontraron ventas en ese período", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (rdbServicio.Checked == true)
                {
                    if (CacheManager.SystemCache.VerificaReporteVentasServicios(Convert.ToDateTime(dtpFechaInicio.Text), Convert.ToDateTime(dtpFechaFin.Text)))
                    {
                        Informes.GUI.Ventas.crvVentasServicios f = new Informes.GUI.Ventas.crvVentasServicios();

                        f.txbFechaInicio.Text = dtpFechaInicio.Text;
                        f.txbFechaFin.Text = dtpFechaFin.Text;
                        f.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron servicios realizados en ese período", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (rdbProducto.Checked == true)
                {
                    if (rdbAllProMar.Checked == true)
                    {
                        if (CacheManager.SystemCache.VerificaReporteVentasProductos(Convert.ToDateTime(dtpFechaInicio.Text), Convert.ToDateTime(dtpFechaFin.Text)))
                        {
                            Informes.GUI.Ventas.crvVentasProductos f = new Informes.GUI.Ventas.crvVentasProductos();

                            f.txbFechaInicio.Text = dtpFechaInicio.Text;
                            f.txbFechaFin.Text = dtpFechaFin.Text;
                            f.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron productos vendidos en ese período", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if (rdbProEspecifico.Checked == true)
                    {
                        if (CacheManager.SystemCache.VerificaReporteVentasProductosEspecifico(Convert.ToInt32(txbIdProducto.Text), Convert.ToDateTime(dtpFechaInicio.Text), Convert.ToDateTime(dtpFechaFin.Text)))
                        {
                            Informes.GUI.Ventas.crvProductoEspecifico f = new Informes.GUI.Ventas.crvProductoEspecifico();

                            f.txbIdProducto.Text = txbIdProducto.Text;
                            f.txbFechaInicio.Text = dtpFechaInicio.Text;
                            f.txbFechaFin.Text = dtpFechaFin.Text;
                            f.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron ventas de " + txbProducto.Text + " en ese período", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if (rdbMarcaEspecifica.Checked == true)
                    {
                        if (CacheManager.SystemCache.VerificaReporteVentasMarcaEspecifica(Convert.ToInt32(txbIdMarca.Text), Convert.ToDateTime(dtpFechaInicio.Text), Convert.ToDateTime(dtpFechaFin.Text)))
                        {
                            Informes.GUI.Ventas.crvVentasMarcaEspecifica f = new Informes.GUI.Ventas.crvVentasMarcaEspecifica();

                            f.txbIdMarca.Text = txbIdMarca.Text;
                            f.txbFechaInicio.Text = dtpFechaInicio.Text;
                            f.txbFechaFin.Text = dtpFechaFin.Text;
                            f.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron ventas de " + txbMarca.Text + " en ese período", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private Boolean Verificacion()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (rdbGeneral.Checked == false && rdbServicio.Checked == false && rdbProducto.Checked == false)
            {
                Notificador.SetError(gpbTipoVenta, "Seleccione un una opción");
            }
            else if (rdbProducto.Checked == true)
            {
                if (rdbAllProMar.Checked == false && rdbProEspecifico.Checked == false && rdbMarcaEspecifica.Checked == false)
                {
                    Notificador.SetError(gpbTipoVenta, "Seleccione un una opción");
                }
                else if (rdbProEspecifico.Checked == true)
                {
                    if (txbProducto.TextLength <= 0) { Verificado = false; Notificador.SetError(btnProducto, "Seleccione un producto"); }
                }
                else if (rdbMarcaEspecifica.Checked == true)
                {
                    if (txbMarca.TextLength <= 0) { Verificado = false; Notificador.SetError(btnMarca, "Seleccione una marca"); }
                }
            }

            return Verificado;
        }

        public CapDatReporteVentas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            GUI.Consumibles.GestionConsumibles f = new GUI.Consumibles.GestionConsumibles();
            AddOwnedForm(f);
            f.Todos = false;
            f.SoloConsultas = false;
            f.TipoOperacion = 0;
            f.Seleccionar = true;
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
                f.TipoOperacion = 0;
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
            f.TipoOperacion = 0;
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
                f.TipoOperacion = 0;
                f.ShowDialog();
            }
        }

        private void rdbProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProducto.Checked == true)
            {
                rdbAllProMar.Enabled = true;
                rdbProEspecifico.Enabled = true;
                rdbMarcaEspecifica.Enabled = true;
            }
        }

        private void rdbServicio_CheckedChanged(object sender, EventArgs e)
        {
            rdbAllProMar.Enabled = false;
            rdbProEspecifico.Enabled = false;
            rdbMarcaEspecifica.Enabled = false;
            txbIdProducto.Clear();
            txbProducto.Clear();
            btnProducto.Enabled = false;
            txbIdMarca.Clear();
            txbMarca.Clear();
            btnMarca.Enabled = false;

            rdbAllProMar.Checked = false;
            rdbProEspecifico.Checked = false;
            rdbMarcaEspecifica.Checked = false;
        }

        private void rdbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            rdbAllProMar.Enabled = false;
            rdbProEspecifico.Enabled = false;
            rdbMarcaEspecifica.Enabled = false;
            txbIdProducto.Clear();
            txbProducto.Clear();
            btnProducto.Enabled = false;
            txbIdMarca.Clear();
            txbMarca.Clear();
            btnMarca.Enabled = false;

            rdbAllProMar.Checked = false;
            rdbProEspecifico.Checked = false;
            rdbMarcaEspecifica.Checked = false;
        }

        private void rdbAllProMar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAllProMar.Checked == true)
            {
                txbIdProducto.Clear();
                txbProducto.Clear();
                btnProducto.Enabled = false;
                txbIdMarca.Clear();
                txbMarca.Clear();
                btnMarca.Enabled = false;
            }
        }

        private void rdbProEspecifico_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProEspecifico.Checked == true)
            {
                btnProducto.Enabled = true;
                txbIdMarca.Clear();
                txbMarca.Clear();
                btnMarca.Enabled = false;
            }
        }

        private void rdbMarcaEspecifica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMarcaEspecifica.Checked == true)
            {
                btnMarca.Enabled = true;
                txbIdProducto.Clear();
                txbProducto.Clear();
                btnProducto.Enabled = false;
            }
        }

        private void btnGenerar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void btnCancelar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Close();
            }
        }
    }
}
