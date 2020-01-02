using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Usuarios
{
    public partial class GestionUsuarios : Form
    {
        BindingSource _Usuarios = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _Usuarios.DataSource = CacheManager.SystemCache.TodosUsuarios();
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
                    _Usuarios.Filter = "usuario LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Usuarios.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Usuarios;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }

        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionUsuarios f = new EdicionUsuarios();
            f.lblID.Visible = false;
            f.txbIdUsuario.Visible = false;
            f.lblUsuario.Margin = new Padding(0, 0, 0, 0);
            f.lblRol.Margin = new Padding(3, 15, 3, 0);
            f.cmbRoles.Margin = new Padding(3, 5, 3, 0);
            f.lblEstado.Margin = new Padding(30, 0, 3, 0);
            f.lblIdAInsertarReferencia.Text = dtgvDatos.Rows[0].Cells["idusuarioNuevo"].Value.ToString();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dtgvDatos.Rows.Count.ToString()) <= 0)
            {
                MessageBox.Show("Actualmente no existe ningún registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EdicionUsuarios f = new EdicionUsuarios();

                    //Sincronizando interfaz gráfica con registro seleccionado
                    //(Muestra los datos del registro a editar)
                    if (dtgvDatos.CurrentRow.Cells["estado"].Value.ToString() == "ACTIVO")
                    {
                        f.rdbActivo.Checked = true;
                    }
                    else
                    {
                        f.rdbBloqueado.Checked = true;
                    }

                    if (Convert.ToInt32(dtgvDatos.CurrentRow.Cells["Empleado"].Value.ToString()) == 1)
                    {
                        f.rdbEmpleado.Checked = true;
                        f.txbIdPropietario.Text = dtgvDatos.CurrentRow.Cells["idempleado"].Value.ToString();
                        f.idPropietario = Convert.ToInt32(dtgvDatos.CurrentRow.Cells["idempleado"].Value.ToString());
                        f.txbPropietario.Text = dtgvDatos.CurrentRow.Cells["propietarioEmpleado"].Value.ToString();
                        f.tipo = "Empleado";
                    }
                    else
                    {
                        f.rdbMedico.Checked = true;
                        f.txbIdPropietario.Text = dtgvDatos.CurrentRow.Cells["idmedico"].Value.ToString();
                        f.idPropietario = Convert.ToInt32(dtgvDatos.CurrentRow.Cells["idmedico"].Value.ToString());
                        f.txbPropietario.Text = dtgvDatos.CurrentRow.Cells["propietarioMedico"].Value.ToString();
                        f.tipo = "Medico";
                    }

                    f.txbIdUsuario.Text = dtgvDatos.CurrentRow.Cells["idusuario"].Value.ToString();
                    f.usuario = dtgvDatos.CurrentRow.Cells["usuario"].Value.ToString();
                    f.txbUsuario.Text = dtgvDatos.CurrentRow.Cells["usuario"].Value.ToString();
                    f.cmbRoles.SelectedValue = dtgvDatos.CurrentRow.Cells["idrol"].Value.ToString();

                    f.ShowDialog();
                    CargarDatos();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dtgvDatos.Rows.Count.ToString()) <= 0)
            {
                MessageBox.Show("Actualmente no existe ningún registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Usuarios oUsuarios = new CLS.Usuarios();
                    CLS.UsuariosMedicosEmpleados oUserMedicoEmpleado = new CLS.UsuariosMedicosEmpleados();
                    oUsuarios.Idusuario = Convert.ToInt32(dtgvDatos.CurrentRow.Cells["idusuario"].Value.ToString());
                    oUserMedicoEmpleado.Idusuario = Convert.ToInt32(dtgvDatos.CurrentRow.Cells["idusuario"].Value.ToString());

                    if (Convert.ToUInt32(dtgvDatos.CurrentRow.Cells["Empleado"].Value.ToString()) == 1)
                    {
                        //Eliminanos las referencias de los empleados
                        oUserMedicoEmpleado.EliminarUserEmpleado();
                    }
                    else
                    {
                        if (Convert.ToUInt32(dtgvDatos.CurrentRow.Cells["Medico"].Value.ToString()) == 1)
                        {
                            //Eliminamos las referencias de los medicos
                            oUserMedicoEmpleado.EliminarUserMedico();
                        }
                    }

                    //Eliminamos el registro
                    if (oUsuarios.Eliminar())
                    {
                        //Si se elimino correctamente notificamos q se realizo bien
                        MessageBox.Show("Registro eliminado exitosamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("El registro no pudo ser eliminado correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }
    }
}
