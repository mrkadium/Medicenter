﻿using System;
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
    public partial class GestionEmpleados : Form
    {
        BindingSource _Empleados = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _Empleados.DataSource = CacheManager.SystemCache.Todos_empleados();
                FiltrarLocalmente();
            }
            catch { }
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txbFiltro.TextLength > 0)
                {
                    _Empleados.Filter = "nombres LIKE '%" + txbFiltro.Text + "%' OR apellidos LIKE '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _Empleados.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Empleados;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }
        public GestionEmpleados()
        {
            InitializeComponent();
        }

        private void GestionEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionEmpleados f = new EdicionEmpleados();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea editar ese registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EdicionEmpleados f = new EdicionEmpleados();

                f.txbIdEmpleado.Text = dtgvDatos.CurrentRow.Cells["IdEmpleado"].Value.ToString();
                f.txbNombres.Text = dtgvDatos.CurrentRow.Cells["Nombres"].Value.ToString();
                f.txbApellidos.Text = dtgvDatos.CurrentRow.Cells["Apellidos"].Value.ToString();
                f.dtpFechaNacimiento.Text = dtgvDatos.CurrentRow.Cells["Fecha_Nacimiento"].Value.ToString();
                f.txbDireccion.Text = dtgvDatos.CurrentRow.Cells["Direccion"].Value.ToString();
                f.txbDui.Text = dtgvDatos.CurrentRow.Cells["Dui"].Value.ToString();
                f.txbNit.Text = dtgvDatos.CurrentRow.Cells["Nit"].Value.ToString();
                f.txbTelefono.Text = dtgvDatos.CurrentRow.Cells["Telefono"].Value.ToString();

                f.ShowDialog();

                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea eliminar ese registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Empleado oEmpleado = new CLS.Empleado();
                oEmpleado.IDEmpleado =  dtgvDatos.CurrentRow.Cells["IdEmpleado"].Value.ToString();
                if (oEmpleado.Eliminar())
                {
                    MessageBox.Show("Borrado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Registro no borrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}