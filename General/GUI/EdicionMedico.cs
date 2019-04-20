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
    public partial class EdicionMedico : Form
    {
        private void Procesar()
        {
            if (Verificacion())
            {
                CLS.Medico oMedico = new CLS.Medico();
                oMedico.Idmedico = txbIDMedico.Text;
                oMedico.JVPM = txbJVPM.Text;
                oMedico.Nombres = txbNombres.Text;
                oMedico.Apellidos = txbApellidos.Text;
                oMedico.Genero = cmbGenero.SelectedValue.ToString();
                oMedico.FechaNacimiento = dtpFechaNacimiento.Text;
                oMedico.Municipio = txbMunicipio.Text;
                oMedico.Direccion = txbDireccion.Text;
                oMedico.DUI = txbDui.Text;
                oMedico.NIT = txbNit.Text;
                oMedico.FechaContratacion = FechaContratacion();
                oMedico.FechaSalida = FechaSalida();
                oMedico.Estado = cmbEstado.SelectedValue.ToString();
                oMedico.IDDepartamento = cmbDepartamento.SelectedValue.ToString();
                

                if (txbIDMedico.Text.Length == 0)
                {
                    //INSERTANDO
                    if (oMedico.Guardar())
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
                    //ACTUALIZANDO
                    if (oMedico.Actualizar())
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

            if (txbJVPM.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbJVPM, "Este campo debe llenarse"); }
            if (txbNombres.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbNombres, "Este campo debe llenarse"); }
            if (txbApellidos.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbApellidos, "Este campo debe llenarse"); }
            //if (cmbGenero.Text.Length <= 0) { Verificado = false; Notificador.SetError(cmbGenero, "Este campo debe llenarse"); }
            //if (dtpFechaNacimiento.Text.Length <= 0) { Verificado = false; Notificador.SetError(dtpFechaNacimiento, "Este campo debe llenarse"); }
            if (txbMunicipio.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbMunicipio, "Este campo debe llenarse"); }
            if (txbDireccion.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbDireccion, "Este campo debe llenarse"); }
            if (txbDui.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbDui, "Este campo debe llenarse"); }
            if (txbNit.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbNit, "Este campo debe llenarse"); }
            //if (cmbEstado.Text.Length <= 0) { Verificado = false; Notificador.SetError(cmbEstado, "Este campo debe llenarse"); }
            //if (cmbDepartamento.Text.Length <= 0) { Verificado = false; Notificador.SetError(cmbDepartamento, "Este campo debe llenarse"); }

            return Verificado;
        }

        public EdicionMedico()
        {
            InitializeComponent();
            CargarEstados();
            CargarGeneros();       
            CargarDepartamentos();
            CargarFContratacion();
            CargarFSalida();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarEstados()
        {
            cmbEstado.DataSource = CLS.cmbEstados.Estados();
            cmbEstado.DisplayMember = "Dmember";
            cmbEstado.ValueMember = "Vmember";
        }

        private void CargarGeneros()
        {
            cmbGenero.DataSource = CLS.cmbEstados.Generos();
            cmbGenero.DisplayMember = "Dmember";
            cmbGenero.ValueMember = "Vmember";
        }        

        private void CargarDepartamentos()
        {
            cmbDepartamento.DataSource = CacheManager.SystemCache.Todos_departamentos();
            cmbDepartamento.DisplayMember = "departamento";
            cmbDepartamento.ValueMember = "iddepartamento";
        }

        private void CargarFContratacion()
        {
            if(dtpContratacion.Text == "null")
            {
                dtpContratacion.Checked = false;
            }
            else
            {
                dtpContratacion.Checked = true;
            }
        }

        private void CargarFSalida()
        {
            if (dtpSalida.Text == "null")
            {
                dtpSalida.Checked = false;
            }
            else
            {
                dtpSalida.Checked = true;
            }
        }

        public String FechaContratacion()
        {
            if (dtpContratacion.Checked)
            {
                return dtpContratacion.Text;
            }
            else
            {
                return "null";
            }
        }

        public String FechaSalida()
        {
            if (dtpSalida.Checked)
            {
                return dtpSalida.Text;
            }
            else
            {
                return "null";
            }
        }
    }
}
