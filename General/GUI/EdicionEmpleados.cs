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
    public partial class EdicionEmpleados : Form
    {
        private void Procesar()
        {
            if (Verificacion())
            {
                CLS.Empleado oEmpleado = new CLS.Empleado();
                oEmpleado.IDEmpleado = txbIdEmpleado.Text;
                oEmpleado.Nombres= txbNombres.Text;
                oEmpleado.Apellidos = txbApellidos.Text;
                oEmpleado.FechaNacimiento = dtpFechaNacimiento.Text;
                oEmpleado.DUI = txbDui.Text;
                oEmpleado.NIT = txbNit.Text;
                oEmpleado.Direccion = txbMunicipio.Text;

                if(txbIdEmpleado.Text.Length == 0)
                {
                    //INSERTANDO
                    if (oEmpleado.Guardar())
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
                    if(oEmpleado.Actualizar())
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

            if (txbNombres.Text.Length <= 0){Verificado = false; Notificador.SetError(txbNombres, "Este campo debe llenarse"); }
            if (txbApellidos.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbApellidos, "Este campo debe llenarse"); }
            if (dtpFechaNacimiento.Text.Length <= 0) { Verificado = false; Notificador.SetError(dtpFechaNacimiento, "Este campo debe llenarse"); }
            if (txbDui.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbDui, "Este campo debe llenarse"); }
            if (txbNit.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbNit, "Este campo debe llenarse"); }
            if (txbMunicipio.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbMunicipio, "Este campo debe llenarse"); }

            return Verificado;
        }

        public EdicionEmpleados()
        {
            InitializeComponent();

            //CARGANDO COMBOBOXES
            cmbEstado.DataSource = CLS.cmbEstados.estados();
            cmbEstado.DisplayMember = "Dmember";
            cmbEstado.ValueMember = "Vmember";
            cmbGenero.DataSource = CLS.cmbEstados.generos();
            cmbGenero.DisplayMember = "Dmember";
            cmbGenero.ValueMember = "Vmember";
            cmbDepartamento.DataSource = CacheManager.SystemCache.Todos_departamentos();
            cmbDepartamento.DisplayMember = "departamento";
            cmbDepartamento.ValueMember = "iddepartamento";
            cmbCargo.DataSource = CacheManager.SystemCache.Todos_cargos();
            cmbCargo.DisplayMember = "cargo";
            cmbCargo.ValueMember = "idcargo";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
