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
    public partial class EdicionUsuarios : Form
    {
        private void Procesar()
        {
            if (Verificacion())
            {
                CLS.Usuario oUsuario = new CLS.Usuario();

                oUsuario.IDUsuario = txbIdUsuario.Text;
                oUsuario.uUsuario = txbUsuario.Text;
                oUsuario.Credencial = txbCredencial.Text;
                oUsuario.IDRol = cmbRol.SelectedValue.ToString();
                oUsuario.IDEmpleado = txbIdEmpleado.Text;
                oUsuario.Estado = cmbEstado.SelectedValue.ToString();

                if (txbIdUsuario.Text.Length == 0)
                {
                    //INSERTANDO
                    if (oUsuario.Guardar())
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
                    if (oUsuario.Actualizar())
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

            if (txbUsuario.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbUsuario, "Este campo debe llenarse"); }
            if (txbCredencial.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbCredencial, "Este campo debe llenarse"); }
            if (cmbRol.SelectedIndex <= 0) { Verificado = false; Notificador.SetError(cmbRol, "Este campo debe llenarse"); }
            if (txbIdEmpleado.Text.Length <= 0) { Verificado = false; Notificador.SetError(txbIdEmpleado, "Este campo debe llenarse"); }
            if (cmbEstado.Text.Length <= 0) { Verificado = false; Notificador.SetError(cmbEstado, "Este campo debe llenarse"); }

            return Verificado;
        }
        public EdicionUsuarios()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            GestionEmpleados f = new GestionEmpleados();

            f.btnSeleccionar.Visible = true;
            f.btnAgregar.Visible = false;
            f.sep1.Visible = false;
            f.btnEditar.Visible = false;
            f.sep2.Visible = false;
            f.btnEliminar.Visible = false;

            f.ShowDialog();
            txbIdEmpleado.Text = f.dtgvDatos.CurrentRow.Cells["IdEmpleado"].Value.ToString();
            txbEmpleado.Text = f.dtgvDatos.CurrentRow.Cells["Nombres"].Value.ToString() + " " + f.dtgvDatos.CurrentRow.Cells["Apellidos"].Value.ToString();
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
