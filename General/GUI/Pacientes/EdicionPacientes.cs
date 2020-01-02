using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Pacientes
{
    public partial class EdicionPacientes : Form
    {
        private void Procesar()
        {
            if (Verificacion() && VerificacionTxbTelefono() && VerificacionEmail())
            {
                CLS.Pacientes oPacientes = new CLS.Pacientes();

                oPacientes.Expediente = Convert.ToInt32(txbExpediente.Text);
                oPacientes.Nombres = txbNombres.Text;
                oPacientes.Apellidos = txbApellidos.Text;
                oPacientes.FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Text);
                oPacientes.Genero = cmbGenero.SelectedValue.ToString();

                if (txbTelefono.Text == "    -")
                {
                    oPacientes.Telefono = "null";
                }
                else
                {
                    oPacientes.Telefono = txbTelefono.Text;
                }
                if (txbEmail.Text.Length == 0)
                {
                    oPacientes.Email = "null";
                }
                else
                {
                    oPacientes.Email = txbEmail.Text;
                }
                oPacientes.Municipio = txbMunicipio.Text;
                oPacientes.Iddepartamento = Convert.ToInt32(cmbDepartamento.SelectedValue.ToString());


                if (txbIDMedico.Text.Length == 0)
                {
                    //INSERTANDO
                    if (oPacientes.Guardar())
                    {
                        MessageBox.Show("Guardado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Registro no guardado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    //oEspecialidad.Idespecialidad = int.Parse(id);
                    oPacientes.Idpaciente = Convert.ToInt32(txbIDMedico.Text);

                    //ACTUALIZANDO
                    if (oPacientes.Actualizar())
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

            if (txbExpediente.TextLength <= 0) { Verificado = false; Notificador.SetError(txbExpediente, "Este campo debe llenarse"); }
            if (txbNombres.TextLength <= 0) { Verificado = false; Notificador.SetError(txbNombres, "Este campo debe llenarse"); }
            if (txbApellidos.TextLength <= 0) { Verificado = false; Notificador.SetError(txbApellidos, "Este campo debe llenarse"); }
            if (txbMunicipio.TextLength <= 0) { Verificado = false; Notificador.SetError(txbMunicipio, "Este campo debe llenarse"); }

            return Verificado;
        }

        private Boolean VerificacionTxbTelefono()
        {
            Boolean Verificado = true;
            Notificador.Clear();
            
            if (txbTelefono.Text == "    -")
            {
                Verificado = true;
            }
            else
            {
                if (!txbTelefono.MaskFull)
                {
                    Verificado = false;
                    Notificador.SetError(txbTelefono, "Campo incompleto");
                }
            }
            
            return Verificado;
        }

        private Boolean VerificacionEmail()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbEmail.Text.Length <= 0)
            {
                Verificado = true;
            }
            else
            {
                if (!IsValidEmail(txbEmail.Text))
                {
                    Verificado = false;
                    Notificador.SetError(txbEmail, "El formato correcto es 'ejemplo@dominio.com'");
                }
            }

            return Verificado;
        }

        public EdicionPacientes()
        {
            InitializeComponent();
            CargarDepartamentos();
            CargarGeneros();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarDepartamentos()
        {
            cmbDepartamento.DataSource = CacheManager.SystemCache.TodosDepartamentos();
            cmbDepartamento.DisplayMember = "departamento";
            cmbDepartamento.ValueMember = "iddepartamento";
        }

        private void CargarGeneros()
        {
            cmbGenero.DataSource = CLS.cmbEstados.Generos();
            cmbGenero.DisplayMember = "Dmember";
            cmbGenero.ValueMember = "Vmember";
        }

        private void txbExpediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        public static bool IsValidEmail(string Email)
        {
            String strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            
            if (re.IsMatch(Email))
            {
                return (true);
            }
            else
            {
                return (false);
            }            
        }

        private void txbNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan letras
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //Permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))   //Permitir el espacio 
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;   //el resto de teclas pulsadas se desactivan
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void txbApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan letras
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //Permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))   //Permitir el espacio 
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;   //el resto de teclas pulsadas se desactivan
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void txbMunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan letras
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //Permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))   //Permitir el espacio 
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;   //el resto de teclas pulsadas se desactivan
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void txbTelefono_Leave(object sender, EventArgs e)
        {
            VerificacionTxbTelefono();
        }

        private void txbEmail_Leave(object sender, EventArgs e)
        {
            VerificacionEmail();          
        }

        private void txbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (Char.IsSeparator(e.KeyChar))   //No permitir el espacio 
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void btnGuardar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void dtpFechaNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void cmbGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbGenero.DroppedDown == false)
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    Procesar();
                }
            }
        }

        private void txbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void cmbDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbDepartamento.DroppedDown == false)
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    Procesar();
                }
            }
        }

        private void btnCancelar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Close();
            }
        }

        private void cmbGenero_Enter(object sender, EventArgs e)
        {
            cmbGenero.DroppedDown = true;
        }

        private void cmbDepartamento_Enter(object sender, EventArgs e)
        {
            cmbDepartamento.DroppedDown = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
