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
    public partial class EdicionCompra : Form
    {
        //CAMBIA LAS COMAS POR PUNTOS EN LOS TEXTOS CON NÚMEROS
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

        public EdicionCompra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedores.GestionProveedores f = new Proveedores.GestionProveedores();
            f.btnAgregar.Visible = false;
            f.btnEditar.Visible = false;
            f.btnEliminar.Visible = false;
            f.btnSeleccionar.Visible = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.ShowDialog();
            txbIdProveedor.Text = f.dtgvDatos.CurrentRow.Cells["idlaboratorio"].Value.ToString();
            txbProveedor.Text = f.dtgvDatos.CurrentRow.Cells["nombre"].Value.ToString();
        }

        private void EdicionCompra_Load(object sender, EventArgs e)
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
                        Notificador.SetError(txbIdProducto, "Este producto ya está en la lista");
                    }
                }
                if (!found)
                {
                    dtgvDatosProducto.Rows.Add(
                        txbIdProducto.Text,
                        txbProducto.Text,
                        txbCantidad.Text,
                        txbPrecioCompra.Text,
                        txbPrecioVenta.Text);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            General.GUI.Consumibles.GestionConsumibles f = new Consumibles.GestionConsumibles();
            f.Todos = false;
            f.btnAgregar.Visible = false;
            f.btnEditar.Visible = false;
            f.btnEliminar.Visible = false;
            f.btnSeleccionar.Visible = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.ShowDialog();

            //SE CARGAN LOS PRECIOS DEL PRODUCTO
            DataTable r = CacheManager.SystemCache.PrecioCompraVenta(f.dtgvDatos.CurrentRow.Cells["idconsumible"].Value.ToString());
            txbPrecioCompra.Text = ConvertToDot(r.Rows[0].ItemArray[0].ToString());
            txbPrecioVenta.Text = ConvertToDot(r.Rows[0].ItemArray[1].ToString());

            txbIdProducto.Text = f.dtgvDatos.CurrentRow.Cells["idconsumible"].Value.ToString();
            txbProducto.Text = f.dtgvDatos.CurrentRow.Cells["nombre"].Value.ToString();
        }

        private void btnQuitarProd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgvDatosProducto.RowCount; i++)
            {
                if (dtgvDatosProducto.Rows[i].Cells["idconsumible"].Value.ToString().Equals(dtgvDatosProducto.CurrentRow.Cells["idconsumible"].Value.ToString()))
                {
                    dtgvDatosProducto.Rows.RemoveAt(i);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private Boolean Verificacion()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbIdProveedor.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txbIdProveedor, "Este campo debe llenarse");
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
            if (txbPrecioCompra.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txbPrecioCompra, "Este campo debe llenarse");
            }
            if (txbPrecioVenta.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txbPrecioVenta, "Este campo debe llenarse");
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
                CLS.Compra oCompra = new CLS.Compra();
                DataTable r = CacheManager.SystemCache.Clinica(1);
                String nombre = r.Rows[0].ItemArray[0].ToString();
                oCompra.ID = txbIdOperacion.TextLength > 0 ? int.Parse(txbIdOperacion.Text) : 0;
                oCompra.IDTitular = 1;
                oCompra.Titular = nombre;
                oCompra.IDLaboratorio = int.Parse(txbIdProveedor.Text);

                //SE LLENA LA LISTA CON TODOS LOS PRODUCTOS
                List<CLS.VMConsumible> lista = new List<CLS.VMConsumible>();
                for (int i = 0; i < dtgvDatosProducto.RowCount; i++)
                {
                    CLS.VMConsumible con = new CLS.VMConsumible();
                    con.IDConsumible = int.Parse(dtgvDatosProducto.Rows[i].Cells["idconsumible"].Value.ToString());
                    con.Consumible = dtgvDatosProducto.Rows[i].Cells["consumible"].Value.ToString();
                    con.Cantidad = int.Parse(dtgvDatosProducto.Rows[i].Cells["cantidad"].Value.ToString());
                    con.PrecioCompra = double.Parse(dtgvDatosProducto.Rows[i].Cells["preciocompra"].Value.ToString(), System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                    con.PrecioVenta = Convert.ToDouble(dtgvDatosProducto.Rows[i].Cells["precioventa"].Value.ToString(), System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                    //float.Parse("41.00027357629127", CultureInfo.InvariantCulture.NumberFormat);
                    //double.Parse("52.8725945", System.Globalization.CultureInfo.InvariantCulture);
                    lista.Add(con);
                }
                oCompra.ListaProductos = lista;

                if (txbIdOperacion.TextLength == 0)
                {
                    //Estoy insertando un nuevo regitro
                    if (oCompra.Guardar())
                    {
                        MessageBox.Show("Registro guardado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txbPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txbPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }
    }
}
