using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Proveedores
{
    public partial class EdicionProveedor : Form
    {
        private Boolean Verificacion()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbNombre.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txbNombre, "Este campo debe llenarse");
            }
            if (txbDescripcion.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txbDescripcion, "Este campo debe llenarse");
            }
            if (txbMunicipio.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txbMunicipio, "Este campo debe llenarse");
            }

            return Verificado;
        }

        public void Procesar()
        {
            CLS.Laboratorio oLaboratorio = new CLS.Laboratorio();
            oLaboratorio.Nombre = txbNombre.Text;
            oLaboratorio.Departamento = cmbDeptos.SelectedValue.ToString();
            oLaboratorio.Municipio = txbMunicipio.Text;
            oLaboratorio.Descripcion = txbDescripcion.Text;

            if (txbIdLaboratorio.TextLength == 0)
            {
                //Estoy insertando un nuevo regitro
                if (oLaboratorio.Guardar())
                {
                    MessageBox.Show("Registro guardado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser guardado correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //Estoy actualizando un registro
                if (oLaboratorio.Actualizar())
                {
                    MessageBox.Show("Registro actualizado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser actualizado correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public EdicionProveedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Verificacion())
                Procesar();
        }

        private void EdicionProveedor_Load(object sender, EventArgs e)
        {
            cmbDeptos.DataSource = CacheManager.SystemCache.TodosDepartamentos();
            cmbDeptos.DisplayMember = "departamento";
            cmbDeptos.ValueMember = "iddepartamento";
        }
    }
}
