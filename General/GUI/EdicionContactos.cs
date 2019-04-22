using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class EdicionContactos : Form
    {
        private void Procesar()
        {
            if (Verificacion())
            {
                CLS.Contacto oContacto = new CLS.Contacto();
                if (rdbEmpleado.Checked == true)
                {
                    oContacto.Para = rdbEmpleado.Text;
                }
                else
                {
                    oContacto.Para = rdbMedico.Text;
                }
                oContacto.IDPropietario = lblIDPropietario.Text;
                oContacto.Tipo = cmbTipo.SelectedValue.ToString();
                oContacto.NombreContacto = txbContacto.Text;


                if (txbIDContacto.Text.Length == 0)
                {
                    //INSERTANDO
                    if (oContacto.Guardar())
                    {
                        MessageBox.Show("Guardado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Desea agregar más contactos al mismo empleado/médico?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            EdicionContactos f = new EdicionContactos();

                            if (rdbEmpleado.Checked == true)
                            {
                                f.rdbEmpleado.Checked = true;
                            }
                            else
                            {
                                f.rdbMedico.Checked = true;
                            }
                            f.txbPropietario.Text = txbPropietario.Text;
                            f.lblIDPropietario.Text = lblIDPropietario.Text;
                            f.ShowDialog();
                        }
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Registro no guardado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    //ACTUALIZANDO
                    if (oContacto.Actualizar())
                    {
                        MessageBox.Show("Editado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Registro no editado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private Boolean Verificacion()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            //if (gpbFuenteContacto.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbJVPM, "Este campo debe llenarse"); }
            if (txbPropietario.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbPropietario, "Este campo debe llenarse"); }
            if (txbContacto.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbContacto, "Este campo debe llenarse"); }

            return Verificado;
        }

        public EdicionContactos()
        {
            InitializeComponent();
            CargarTiposContactos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarTiposContactos()
        {
            cmbTipo.DataSource = CLS.cmbEstados.TipoContacto();
            cmbTipo.DisplayMember = "Dmember";
            cmbTipo.ValueMember = "Vmember";
        }

        private void btnBuscarPropietario_Click(object sender, EventArgs e)
        {
            if (rdbEmpleado.Checked == false && rdbMedico.Checked == false)
            {
                MessageBox.Show("Selecciona una fuente para el contacto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rdbEmpleado.Checked == true)
                {
                    EleccionEmpleadoParaContactos f = new EleccionEmpleadoParaContactos();
                    AddOwnedForm(f);
                    f.ShowDialog();
                }
                else
                {
                    EleccionMedicosParaContactos f = new EleccionMedicosParaContactos();
                    AddOwnedForm(f);
                    f.ShowDialog();
                }
            }
            
        }
    }
}
