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
    public partial class EleccionEmpleadoParaContactos : Form
    {
        BindingSource _Empleados = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _Empleados.DataSource = CacheManager.SystemCache.Todos_Empleados_Contactos();
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
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
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

        public EleccionEmpleadoParaContactos()
        {
            InitializeComponent();
        }

        private void EleccionEmpleadoParaContactos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            EdicionContactos f = Owner as EdicionContactos;

            //Sincronizando interfaz gráfica con registro seleccionado
            f.lblIDPropietario.Text = dtgvDatos.CurrentRow.Cells["idempleado"].Value.ToString();
            f.txbPropietario.Text = dtgvDatos.CurrentRow.Cells["nombres"].Value.ToString() + " " + dtgvDatos.CurrentRow.Cells["apellidos"].Value.ToString();
            Close();
        }

        private void dtgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EdicionContactos f = Owner as EdicionContactos;

            //Sincronizando interfaz gráfica con registro seleccionado
            f.lblIDPropietario.Text = dtgvDatos.CurrentRow.Cells["idempleado"].Value.ToString();
            f.txbPropietario.Text = dtgvDatos.CurrentRow.Cells["nombres"].Value.ToString() + " " + dtgvDatos.CurrentRow.Cells["apellidos"].Value.ToString();
            Close();
        }
    }
}
