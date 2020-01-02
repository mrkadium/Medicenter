using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Marcas
{
    public partial class EdicionMarca : Form
    {

        private Boolean Verificacion()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbMarc.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txbMarc, "Este campo debe llenarse");
            }

            return Verificado;
        }
        public void Procesar()
        {
            CLS.Marca oMarca = new CLS.Marca();
            oMarca.IDMarca = txbIdMarca.TextLength > 0 ? int.Parse(txbIdMarca.Text) : 0;
            oMarca.Marca1 = txbMarc.Text;

            if (txbIdMarca.TextLength == 0)
            {
                //Estoy insertando un nuevo regitro
                if (oMarca.Guardar())
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
                if (oMarca.Actualizar())
                {
                    MessageBox.Show("Registro actualizado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("El registro está siento usado en otra tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public EdicionMarca()
        {
            InitializeComponent();
        }

        private void txbIdConsumile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblJVPM_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Verificacion())
                Procesar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
