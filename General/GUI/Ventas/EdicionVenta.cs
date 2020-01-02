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
    public partial class EdicionVenta : Form
    {
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
        public EdicionVenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pacientes.GestionPacientes f = new Pacientes.GestionPacientes();
            f.btnAgregar.Visible = false;
            f.btnEditar.Visible = false;
            f.btnEliminar.Visible = false;
            f.btnSeleccionar.Visible = true;
            f.ShowDialog();
            txbIdTitular.Text = f.dtgvDatos.CurrentRow.Cells["idpaciente"].Value.ToString();
            txbTitular.Text = f.dtgvDatos.CurrentRow.Cells["nombres"].Value.ToString() + " " + f.dtgvDatos.CurrentRow.Cells["apellidos"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            General.GUI.Inventarios.GestionInventarios f = new Inventarios.GestionInventarios();
            f.ShowDialog();
            txbIdProducto.Text = f.dtgvDatos.CurrentRow.Cells["idconsumible"].Value.ToString();
            txbProducto.Text = f.dtgvDatos.CurrentRow.Cells["nombre"].Value.ToString();
            lblLimite.Text = f.dtgvDatos.CurrentRow.Cells["cantidad"].Value.ToString();
            txbPrecioVenta.Text = ConvertToDot(f.dtgvDatos.CurrentRow.Cells["precioventa"].Value.ToString());
        }

        private void btnQuitarProd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgvDatosProducto.RowCount; i++)
            {
                Double cantidad = Convert.ToDouble(dtgvDatosProducto.CurrentRow.Cells[2].Value.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                Double precioventa = Convert.ToDouble(dtgvDatosProducto.CurrentRow.Cells[3].Value.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                Double total = Convert.ToDouble(ConvertToDot(lblTotalNumero.Text), System.Globalization.CultureInfo.InvariantCulture);
                String id = dtgvDatosProducto.Rows[i].Cells[0].Value.ToString();
                String idcurrent = dtgvDatosProducto.CurrentRow.Cells[0].Value.ToString();
                if (id.Equals(idcurrent))
                {
                    dtgvDatosProducto.Rows.RemoveAt(i);

                    lblTotalNumero.Text = (total - (cantidad * precioventa)) + "";
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (VerificacionProducto())
            {
                for (int i = 0; i < dtgvDatosProducto.RowCount; i++)
                {
                    if (dtgvDatosProducto.Rows[i].Cells["idconsumible"].Value.ToString().Equals(txbIdProducto.Text))
                    {
                        found = true;
                        Notificador.SetError(btnAgregarProd, "Este producto ya está en la lista");
                    }
                }
                if (!found)
                {
                    if (int.Parse(lblLimite.Text) >= int.Parse(txbCantidad.Text))
                    {
                        dtgvDatosProducto.Rows.Add(
                        txbIdProducto.Text,
                        txbProducto.Text,
                        txbCantidad.Text,
                        txbPrecioVenta.Text);

                        lblTotalNumero.Text = (Convert.ToDouble(txbPrecioVenta.Text, System.Globalization.CultureInfo.InvariantCulture) * Convert.ToDouble(txbCantidad.Text, System.Globalization.CultureInfo.InvariantCulture) + Convert.ToDouble(ConvertToDot(lblTotalNumero.Text), System.Globalization.CultureInfo.InvariantCulture)) + "";
                    }
                    else if (txbCantidad.Text.Length == 0)
                    {
                        Notificador.SetError(txbCantidad, "Debe especificar una cantidad");
                    }
                    else
                    {
                        Notificador.SetError(txbCantidad, "Está excediendo el límite de este producto");
                    }
                }
            }
        }
        private Boolean Verificacion()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbIdTitular.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txbIdTitular, "Este campo debe llenarse");
            }
            if (dtgvDatosProducto.RowCount <= 0)
            {
                Verificado = false;
                Notificador.SetError(dtgvDatosProducto, "Para realizar una compra debe haber productos en la lista");
            }

            return Verificado;
        }

        private Boolean VerificacionProducto()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbIdProducto.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txbIdProducto, "Este campo debe llenarse");
            }
            if (txbCantidad.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txbCantidad, "Este campo debe llenarse");
            }

            return Verificado;
        }

        public void Procesar()
        {
            if (Verificacion())
            {
                CLS.Venta oVenta = new CLS.Venta();
                DataTable r = CacheManager.SystemCache.Clinica(1);
                String nombre = r.Rows[0].ItemArray[0].ToString();
                oVenta.ID = txbIdOperacion.TextLength > 0 ? int.Parse(txbIdOperacion.Text) : 0;
                oVenta.IDTitular = int.Parse(txbIdTitular.Text);
                oVenta.Titular = txbTitular.Text;
                oVenta.IDLaboratorio = 1;

                List<CLS.VMConsumible> lista = new List<CLS.VMConsumible>();
                for (int i = 0; i < dtgvDatosProducto.RowCount; i++)
                {
                    CLS.VMConsumible con = new CLS.VMConsumible();
                    con.IDConsumible = int.Parse(dtgvDatosProducto.Rows[i].Cells["idconsumible"].Value.ToString());
                    con.Consumible = dtgvDatosProducto.Rows[i].Cells["consumible"].Value.ToString();
                    con.Cantidad = int.Parse(dtgvDatosProducto.Rows[i].Cells["cantidad"].Value.ToString());
                    //con.PrecioCompra = double.Parse(dtgvDatosProducto.Rows[i].Cells["preciocompra"].Value.ToString(), System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                    con.PrecioVenta = Convert.ToDouble(dtgvDatosProducto.Rows[i].Cells["precioventa"].Value.ToString(), System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                    //float.Parse("41.00027357629127", CultureInfo.InvariantCulture.NumberFormat);
                    //double.Parse("52.8725945", System.Globalization.CultureInfo.InvariantCulture);
                    lista.Add(con);
                }
                oVenta.ListaProductos = lista;

                if (txbIdOperacion.TextLength == 0)
                {
                    //Estoy insertando un nuevo regitro
                    if (oVenta.Guardar())
                    {
                        MessageBox.Show("Registro guardado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("¿Desea imprimir factura?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                        }
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("El registro está siento usado en otra tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    //Estoy actualizando un registro
                    //if (oCompra.Actualizar())
                    //{
                    //    MessageBox.Show("Registro actualizado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    Close();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("El registro está siento usado en otra tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EdicionVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
