using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Constancias
{
    public partial class CapDatIncapacidad : Form
    {
        private void Procesar()
        {
            if (Verificacion())
            {
                if (rdbIncapacidad.Checked == true)
                {
                    Informes.GUI.Constancias.vrIncapacidadMedica f = new Informes.GUI.Constancias.vrIncapacidadMedica();

                    f.txbIdPaciente.Text = txbIdPaciente.Text;
                    f.txbPaciente.Text = txbPaciente.Text;
                    f.txbIncapacidad.Text = txbIncapacidad.Text;
                    f.Show();
                    Close();
                }
                else if (rdbConstanciaMedica.Checked == true)
                {
                    Informes.GUI.Constancias.crConstanciaMedica f = new Informes.GUI.Constancias.crConstanciaMedica();

                    f.txbIdPaciente.Text = txbIdPaciente.Text;
                    f.txbPaciente.Text = txbPaciente.Text;
                    f.txbIncapacidad.Text = txbIncapacidad.Text;
                    f.Show();
                    Close();
                }
                else if (rdbBuenaSalud.Checked == true)
                {
                    Informes.GUI.Constancias.crvBuenSalud f = new Informes.GUI.Constancias.crvBuenSalud();

                    f.txbIdPaciente.Text = txbIdPaciente.Text;
                    f.txbPaciente.Text = txbPaciente.Text;
                    f.txbidMedico.Text = txbidMedico.Text;
                    f.Show();
                    Close();
                }
            }
        }

        private Boolean Verificacion()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (rdbIncapacidad.Checked == false && rdbConstanciaMedica.Checked == false && rdbBuenaSalud.Checked == false)
            {
                Notificador.SetError(gpbRadioB, "Seleccione un una opción");
            }
            else if(rdbIncapacidad.Checked == true)
            {
                if (txbPaciente.TextLength <= 0) { Verificado = false; Notificador.SetError(btnPaciente, "Seleccione un paciente"); }
                if (txbIncapacidad.TextLength <= 0) { Verificado = false; Notificador.SetError(txbIncapacidad, "Este campo debe llenarse"); }
            }
            else if (rdbConstanciaMedica.Checked == true)
            {
                if (txbPaciente.TextLength <= 0) { Verificado = false; Notificador.SetError(btnPaciente, "Seleccione un paciente"); }
            }
            else if (rdbBuenaSalud.Checked == true)
            {
                if (txbPaciente.TextLength <= 0) { Verificado = false; Notificador.SetError(btnPaciente, "Seleccione un paciente"); }
                if (txbMedico.TextLength <= 0) { Verificado = false; Notificador.SetError(btnMedico, "Seleccione un paciente"); }
            }

            return Verificado;
        }

        public CapDatIncapacidad()
        {
            InitializeComponent();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            GUI.Pacientes.GestionPacientes f = new GUI.Pacientes.GestionPacientes();
            AddOwnedForm(f);
            f.btnAgregar.Visible = false;
            f.btnEditar.Visible = false;
            f.btnEliminar.Visible = false;
            f.btnSeleccionar.Visible = true;
            f.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void rdbIncapacidad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIncapacidad.Checked == true)
            {
                txbIncapacidad.ReadOnly = false;
                txbMedico.Clear();
                txbidMedico.Clear();
            }
            else
            {
                txbIncapacidad.ReadOnly = true;
                txbIncapacidad.TabStop = false;
            }
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            GUI.Medicos.GestionMedicos f = new GUI.Medicos.GestionMedicos();
            AddOwnedForm(f);
            f.btnAgregar.Visible = false;
            f.btnEditar.Visible = false;
            f.btnEliminar.Visible = false;
            f.btnSeleccionar.Visible = true;
            f.TipoOperacion = 1;
            f.ShowDialog();
        }

        private void rdbBuenaSalud_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBuenaSalud.Checked == true)
            {
                btnMedico.Enabled = true;
                txbIncapacidad.Clear();
            }
            else
            {
                btnMedico.Enabled = false;
            }
        }

        private void btnPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                GUI.Pacientes.GestionPacientes f = new GUI.Pacientes.GestionPacientes();
                AddOwnedForm(f);
                f.btnAgregar.Visible = false;
                f.btnEditar.Visible = false;
                f.btnEliminar.Visible = false;
                f.btnSeleccionar.Visible = true;
                f.ShowDialog();
            }
        }

        private void btnCancelar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Close();
            }
        }

        private void btnGenerar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void btnMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                GUI.Medicos.GestionMedicos f = new GUI.Medicos.GestionMedicos();
                AddOwnedForm(f);
                f.btnAgregar.Visible = false;
                f.btnEditar.Visible = false;
                f.btnEliminar.Visible = false;
                f.btnSeleccionar.Visible = true;
                f.TipoOperacion = 1;
                f.ShowDialog();
            }
        }

        private void rdbConstanciaMedica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbConstanciaMedica.Checked == true)
            {
                txbIncapacidad.Clear();
                txbIncapacidad.ReadOnly = true;
                txbMedico.Clear();
                txbidMedico.Clear();
            }
        }

        private void txbIncapacidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
