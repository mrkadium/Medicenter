using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Opciones
{
    public partial class EdicionOpciones : Form
    {
        private void Procesar()
        {
            if (Verificacion())
            {
                CLS.Opciones oOpciones = new CLS.Opciones();

                oOpciones.Opcion = txbOpcion.Text;
                oOpciones.Clasificacion = cmbClasificacion.SelectedValue.ToString();


                if (txbIdOpcion.Text.Length == 0)
                {
                    //INSERTANDO
                    if (oOpciones.Guardar())
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
                    oOpciones.Idopcion = Convert.ToInt32(txbIdOpcion.Text);

                    //ACTUALIZANDO
                    if (oOpciones.Actualizar())
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

            if (txbOpcion.TextLength <= 0) { Verificado = false; Notificador.SetError(txbOpcion, "Este campo debe llenarse"); }

            return Verificado;
        }

        public EdicionOpciones()
        {
            InitializeComponent();
            CargarClasificaciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbOpcion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CargarClasificaciones()
        {
            cmbClasificacion.DataSource = CLS.cmbEstados.Clasificacion();
            cmbClasificacion.DisplayMember = "Dmember";
            cmbClasificacion.ValueMember = "Vmember";
        }

        private void cmbClasificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbClasificacion.DroppedDown == false)
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    Procesar();
                }
            }
        }

        private void btnAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void btnCancelar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Close();
            }
        }

        private void cmbClasificacion_Enter(object sender, EventArgs e)
        {
            cmbClasificacion.DroppedDown = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
