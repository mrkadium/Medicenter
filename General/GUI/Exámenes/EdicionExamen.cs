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
    public partial class EdicionExamen : Form
    {
        bool Editar = false;
        bool Agregar = false;

        public bool Agregar1 { get => Agregar; set => Agregar = value; }
        public bool Editar1 { get => Editar; set => Editar = value; }
        private Boolean Verificacion()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbExamen.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txbExamen, "Este campo debe llenarse");
            }
            if (Editar && txbResultados.TextLength <= 0)
            {
                Verificado = false;
                Notificador.SetError(txbResultados, "Este campo debe llenarse");
            }

            return Verificado;
        }

        public void Procesar()
        {
            CLS.Examen oExamen = new CLS.Examen();
            oExamen.ID = txbIdExamen.TextLength > 0 ? int.Parse(txbIdExamen.Text) : 0;
            oExamen.Resultados = txbResultados.Text;

            if (oExamen.Actualizar())
            {
                MessageBox.Show("Registro actualizado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("El registro no pudo ser actualizado correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public EdicionExamen()
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

        private void EdicionExamen_Load(object sender, EventArgs e)
        {
            cmbEstado.DataSource = General.CLS.cmbEstados.EstadoExamen();
            cmbEstado.DisplayMember = "Dmember";
            cmbEstado.ValueMember = "Vmember";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar1)
            {
                Procesar();
            }
            else
            {
                Agregar1 = true;
            }
            Close();
        }
    }
}
