using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.ReportInventario
{
    public partial class CapDatInventarios : Form
    {
        private void Procesar()
        {
            if (Verificacion())
            {
                if (rdbGeneral.Checked == true)
                {
                    if (CacheManager.SystemCache.VerificaReporteInventario())
                    {
                        Informes.GUI.Inventario.crvInventario f = new Informes.GUI.Inventario.crvInventario();

                        f.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Actualmente no se encuentran existencias en el inventario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (rdbMarca.Checked == true)
                {
                    if (CacheManager.SystemCache.VerificaReporteInventarioMarcaEspecifi(Convert.ToInt32(txbIdMarca.Text)))
                    {
                        Informes.GUI.Inventario.crvInventario f = new Informes.GUI.Inventario.crvInventario();

                        f.txbIdMarca.Text = txbIdMarca.Text;
                        f.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron existencias de esa marca", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private Boolean Verificacion()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (rdbGeneral.Checked == false && rdbMarca.Checked == false)
            {
                Notificador.SetError(gpbTipoReporte, "Seleccione un una opción");
            }
            else if (rdbMarca.Checked == true)
            {
                if (txbMarca.TextLength <= 0) { Verificado = false; Notificador.SetError(btnMarca, "Seleccione una marca"); }
            }

            return Verificado;
        }

        public CapDatInventarios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            GUI.Marcas.GestionMarcas f = new GUI.Marcas.GestionMarcas();
            AddOwnedForm(f);
            f.btnAgregar.Visible = false;
            f.btnEditar.Visible = false;
            f.btnEliminar.Visible = false;
            f.btnSeleccionar.Visible = true;
            f.TipoOperacion = 1;
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
                f.TipoOperacion = 1;
                f.ShowDialog();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void rdbMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMarca.Checked == true)
            {
                btnMarca.Enabled = true;
            }
        }

        private void rdbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGeneral.Checked == true)
            {
                txbIdMarca.Clear();
                txbMarca.Clear();
                btnMarca.Enabled = false;
            }
        }
    }
}
