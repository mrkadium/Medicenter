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
    public partial class EdicionConsumibles : Form
    {
        private Boolean Verificacion()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbIdMarca.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txbIdMarca, "Este campo debe llenarse");
            }
            if (txbNombre.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txbNombre, "Este campo debe llenarse");
            }
            if (txbAlias.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txbAlias, "Este campo debe llenarse");
            }
            if (txbPrecioVenta.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txbPrecioVenta, "Este campo debe llenarse");
            }

            return Verificado;
        }

        public void Procesar()
        {
            CLS.Consumible oConsumible = new CLS.Consumible();
            oConsumible.IDConsumible = txbIdConsumile.TextLength > 0 ? int.Parse(txbIdConsumile.Text) : 0;
            oConsumible.Categoria = cmbCategoria.Text;
            oConsumible.Nombre = txbNombre.Text;
            oConsumible.Alias = txbAlias.Text;
            oConsumible.IDMarca = int.Parse(txbIdMarca.Text);
            oConsumible.PrecioCompra = txbPrecioCompra.Text.Length > 0 ? Double.Parse(txbPrecioCompra.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat) : 0;
            oConsumible.PrecioVenta = Double.Parse(txbPrecioVenta.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);

            if (txbIdConsumile.TextLength == 0)
            {
                //Estoy insertando un nuevo regitro
                if (oConsumible.Guardar())
                {
                    MessageBox.Show("Registro guardado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser guardado correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //Estoy actualizando un registro
                if (oConsumible.Actualizar())
                {
                    MessageBox.Show("Registro actualizado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser actualizado correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public EdicionConsumibles()
        {
            InitializeComponent();
            cmbCategoria.DataSource = CLS.cmbEstados.CategoriaConsumible();
            cmbCategoria.DisplayMember = "Dmember";
            cmbCategoria.ValueMember = "Vmember";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Verificacion())
                Procesar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Marcas.GestionMarcas f = new Marcas.GestionMarcas();
            f.btnSeleccionar.Visible = true;
            f.ShowDialog();
            txbIdMarca.Text = f.dtgvDatos.CurrentRow.Cells["idmarca"].Value.ToString();
            txbMarca.Text = f.dtgvDatos.CurrentRow.Cells["marca"].Value.ToString();
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
