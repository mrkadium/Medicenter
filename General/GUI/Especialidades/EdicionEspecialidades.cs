﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Especialidades
{
    public partial class EdicionEspecialidades : Form
    {
        private void Procesar()
        {
            if (Verificacion())
            {
                CLS.Especialidades oEspecialidad = new CLS.Especialidades();

                oEspecialidad.Especialidad = txbEspecialidad.Text;


                if (txbIDEspecialidad.Text.Length == 0)
                {
                    //INSERTANDO
                    if (oEspecialidad.Guardar())
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
                    oEspecialidad.Idespecialidad = Convert.ToInt32(txbIDEspecialidad.Text);

                    //ACTUALIZANDO
                    if (oEspecialidad.Actualizar())
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
            
            if (txbEspecialidad.TextLength <= 0) { Verificado = false; Notificador.SetError(txbEspecialidad, "Este campo debe llenarse"); }

            return Verificado;
        }

        public EdicionEspecialidades()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
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
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
