using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Operaciones
{
    public partial class GestionConsultas : Form
    {
        public static class OPERACION
        {
            public static int VENTA = 1;
            public static int COMPRA = 2;
            public static int CONSULTA = 3;
        }

        int _Tipo_operacion;


        BindingSource _Consultas = new BindingSource();

        public int Tipo_operacion { get => _Tipo_operacion; set => _Tipo_operacion = value; }

        private void CargarConsultas()
        {
            try
            {
                _Consultas.DataSource = CacheManager.SystemCache.TodasConsultas();
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
                    _Consultas.Filter = "servicio LIKE '%" + txbFiltro.Text + "%' OR medico LIKE '%" + txbFiltro.Text + "%' OR paciente LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Consultas.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Consultas;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }
        public GestionConsultas()
        {
            InitializeComponent();
        }

        SessionManager.Session _Sesion = SessionManager.Session.Instancia;

        private void GestionOperaciones_Load(object sender, EventArgs e)
        {
            CargarConsultas();

            if (!_Sesion.oUsuario.verificarPermiso("AGREGAR"))
            {
                btnRegConsulta.Visible = false;
            }
            if (!_Sesion.oUsuario.verificarPermiso("EDITAR"))
            {
                btnEditar.Visible = false;
            }
        }

        private void btnRegConsulta_Click(object sender, EventArgs e)
        {
            EdicionConsulta f = new EdicionConsulta();
            f.Show();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EdicionConsulta f = new EdicionConsulta();
            f.btnCancelar.Visible = false;
            f.btnGuardar.Visible = false;
            f.flpDatosProducto.Visible = false;
            f.btnAgregarExamen.Visible = false;
            f.btnAgregarProd.Visible = false;
            f.btnQuitarProd.Visible = false;
            f.lblTotal.Visible = false;
            f.flpCuadrotes.Visible = false;
            f.dtgvDatosProducto.Visible = false;
            f.button1.Visible = false;
            f.btnMedico.Visible = false;
            f.btnServicio.Visible = false;
            f.txbPrecioConsulta.Visible = false;
            f.lblPrecioConsulta.Visible = false;
            f.txbIdMedico.Visible = false;
            f.txbIdServicio.Visible = false;
            f.lblMensaje.Text = "Sólo podrá editar los exámenes, cualquier otro cambio en los datos de la consulta se descartará";
            f.lblTotalNumero.Visible = false;
            f.dtgvExamenes.AutoGenerateColumns = false;
            f.label12.Visible = false;
            f.txbIdTitular.Text = dtgvDatos.CurrentRow.Cells["idpaciente"].Value.ToString();
            f.txbTitular.Text = dtgvDatos.CurrentRow.Cells["paciente"].Value.ToString();
            f.txbServicio.Text = dtgvDatos.CurrentRow.Cells["servicio"].Value.ToString();
            f.txbMedico.Text = dtgvDatos.CurrentRow.Cells["medico"].Value.ToString();
            f.dtgvExamenes.DataSource = CacheManager.SystemCache.ExamenesConsulta(int.Parse(dtgvDatos.CurrentRow.Cells["idoperacion"].Value.ToString()));
            f.txbIdOperacion.Text = dtgvDatos.CurrentRow.Cells["idoperacion"].Value.ToString();
            f.ShowDialog();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {

        }
    }
}
