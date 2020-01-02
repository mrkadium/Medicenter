using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Permisos
{
    public partial class GestionPermisos : Form
    {
        BindingSource _Permisos = new BindingSource();

        private void CargarRoles()
        {
            try
            {
                cmbRoles.DataSource = CacheManager.SystemCache.TodosRolesPermisos();
                cmbRoles.DisplayMember = "rol";
                cmbRoles.ValueMember = "idRol";
            }
            catch { }
        }
            
        public GestionPermisos()
        {
            InitializeComponent();
            CargarRoles();
            cmbRoles.SelectedIndex = 0;
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            dtgvDatos.DataSource = CacheManager.SystemCache.ValidacionPermisos(cmbRoles.SelectedValue.ToString());
        }

        private void dtgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int valor = int.Parse(dtgvDatos.CurrentRow.Cells["Asignado"].Value.ToString());
            int idPermiso = int.Parse(dtgvDatos.CurrentRow.Cells["IDAsignacion"].Value.ToString());
            int idRol = int.Parse(cmbRoles.SelectedValue.ToString());
            int idOpcion = int.Parse(dtgvDatos.CurrentRow.Cells["IDOpcion"].Value.ToString());

            if (valor == 1)
            {
                Revocar(idPermiso);
            }
            else
            {
                Asignar(idRol, idOpcion);
            }
            CargarDatos();
        }

        private void Revocar(int pidPermiso)
        {
            CacheManager.SystemCache.EliminarPermiso(pidPermiso);
        }

        private void Asignar(int pidRol, int pidOpcion)
        {
            CacheManager.SystemCache.InsertarPermiso(pidRol, pidOpcion);
        }

        private void cmbRoles_Enter(object sender, EventArgs e)
        {
            cmbRoles.DroppedDown = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
