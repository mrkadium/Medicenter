using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Operaciones
{
    public partial class EdicionConsulta : Form
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
        public EdicionConsulta()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void EdicionConsulta_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            Pacientes.GestionPacientes f = new Pacientes.GestionPacientes();
            f.btnAgregar.Visible = false;
            f.btnEditar.Visible = false;
            f.btnEliminar.Visible = false;
            f.btnSeleccionar.Visible = true;
            f.Incapacidad1 = false;
            f.ShowDialog();
            txbIdTitular.Text = f.dtgvDatos.CurrentRow.Cells["idpaciente"].Value.ToString();
            txbTitular.Text = f.dtgvDatos.CurrentRow.Cells["nombres"].Value.ToString() + " " + f.dtgvDatos.CurrentRow.Cells["apellidos"].Value.ToString();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            General.GUI.Consumibles.GestionConsumibles f = new Consumibles.GestionConsumibles();
            f.SoloConsultas = true;
            f.btnAgregar.Visible = false;
            f.btnEditar.Visible = false;
            f.btnEliminar.Visible = false;
            f.btnSeleccionar.Visible = true;
            f.ShowDialog();
            txbIdServicio.Text = f.dtgvDatos.CurrentRow.Cells["idconsumible"].Value.ToString();
            txbServicio.Text = f.dtgvDatos.CurrentRow.Cells["nombre"].Value.ToString();
            txbPrecioConsulta.Text = ConvertToDot(f.dtgvDatos.CurrentRow.Cells["precioventa"].Value.ToString());
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            General.GUI.Medicos.GestionMedicos f = new Medicos.GestionMedicos();
            f.btnAgregar.Visible = false;
            f.btnEditar.Visible = false;
            f.btnEliminar.Visible = false;
            f.btnSeleccionar.Visible = true;
            f.NoSeleccionMedico = false;
            f.ShowDialog();
            txbIdMedico.Text = f.dtgvDatos.CurrentRow.Cells["idmedico"].Value.ToString();
            txbMedico.Text = f.dtgvDatos.CurrentRow.Cells["Nombres"].Value.ToString() + " " + f.dtgvDatos.CurrentRow.Cells["Apellidos"].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        public void Procesar()
        {
            if (Verificacion())
            {
                CLS.Venta oConsulta = new CLS.Venta();
                oConsulta.Consulta = true; //SE ESPECIFICA QUE ES CONSULTA
                DataTable r = CacheManager.SystemCache.Clinica(1);
                String nombre = r.Rows[0].ItemArray[0].ToString();
                oConsulta.ID = txbIdOperacion.TextLength > 0 ? int.Parse(txbIdOperacion.Text) : 0;
                oConsulta.IDTitular = int.Parse(txbIdTitular.Text);
                oConsulta.Titular = txbTitular.Text;
                oConsulta.IDLaboratorio = 1;

                oConsulta.IDConsulta = int.Parse(txbIdServicio.Text);
                oConsulta.IDMedico = int.Parse(txbIdMedico.Text);
                oConsulta.RazonConsulta = txbRazonConsulta.Text;
                oConsulta.Diagnostico = txbDiagnostico.Text;
                oConsulta.Tratamiento = txbTratamiento.Text;
                oConsulta.Observaciones = txbObservaciones.Text;

                List<CLS.VMConsumible> lista = new List<CLS.VMConsumible>();
                //SE AGREGA CADA PRODUCTO DE LA TABLA A LA LISTA
                //SE AGREGA PRIMERO LA CONSULTA
                lista.Add(new CLS.VMConsumible
                {
                    IDConsumible = int.Parse(txbIdServicio.Text),
                    Consumible = txbServicio.Text,
                    Cantidad = 1,
                    PrecioVenta = Convert.ToDouble(txbPrecioConsulta.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat)
                });
                for (int i = 0; i < dtgvDatosProducto.RowCount; i++)
                {
                    CLS.VMConsumible con = new CLS.VMConsumible();
                    con.IDConsumible = int.Parse(dtgvDatosProducto.Rows[i].Cells["idconsumible"].Value.ToString());
                    con.Consumible = dtgvDatosProducto.Rows[i].Cells["consumible"].Value.ToString();
                    con.Cantidad = int.Parse(dtgvDatosProducto.Rows[i].Cells["cantidad"].Value.ToString());
                    con.PrecioVenta = Convert.ToDouble(dtgvDatosProducto.Rows[i].Cells["precioventa"].Value.ToString(), System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                    lista.Add(con);
                }
                oConsulta.ListaProductos = lista;

                if (txbIdOperacion.TextLength == 0)
                {
                    //Estoy insertando un nuevo regitro
                    if (oConsulta.Guardar())
                    {
                        MessageBox.Show("Registro guardado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("¿Desea imprimir factura?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                        }
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("El registro no se pudo guardar correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnAgregarExamen_Click(object sender, EventArgs e)
        {
            EdicionExamen f = new EdicionExamen();
            f.ShowDialog();
            if (f.Agregar1)
            {
                dtgvExamenes.Rows.Add(
                    f.txbIdExamen.Text,
                    f.txbExamen.Text,
                    f.dtpFecha.Text,
                    f.cmbEstado.Text,
                    f.txbResultados.Text
                    );
            }
        }

        private void btnEditarExamen_Click(object sender, EventArgs e)
        {
            EdicionExamen f = new EdicionExamen();
            f.txbIdOperacion.Text = txbIdOperacion.Text;
            f.txbExamen.Text = dtgvExamenes.CurrentRow.Cells["examen"].Value.ToString();
            f.txbIdExamen.Text = dtgvExamenes.CurrentRow.Cells["idresultado"].Value.ToString();
            f.cmbEstado.SelectedValue = dtgvExamenes.CurrentRow.Cells["estado"].Value.ToString();
            f.dtpFecha.Text = dtgvExamenes.CurrentRow.Cells["fecha"].Value.ToString();
            f.txbResultados.Text = dtgvExamenes.CurrentRow.Cells["resultados"].Value.ToString();

            f.Editar1 = true;
            f.ShowDialog();
            dtgvExamenes.DataSource = CacheManager.SystemCache.ExamenesConsulta(int.Parse(txbIdOperacion.Text));
        }
    }
}
