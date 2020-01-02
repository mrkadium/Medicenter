using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Inventarios
{
    public partial class GestionInventarios : Form
    {
        BindingSource _Inventarios = new BindingSource();
        bool _Todos = false;

        public bool Todos { get => _Todos; set => _Todos = value; }

        private void CargarInventarios()
        {
            try
            {
                if (_Todos)
                {
                    _Inventarios.DataSource = CacheManager.SystemCache.TodosInventariosConServicios();
                }
                else
                {
                    _Inventarios.DataSource = CacheManager.SystemCache.TodosInventarios();
                }
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
                    _Inventarios.Filter = "producto LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Inventarios.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Inventarios;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }

        public GestionInventarios()
        {
            InitializeComponent();
        }

        private void GestionInventarios_Load(object sender, EventArgs e)
        {
            CargarInventarios();
        }
    }
}
