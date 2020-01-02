using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Empleados
{
    public partial class GestionEmpleados : Form
    {
        BindingSource _Empleados = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _Empleados.DataSource = CacheManager.SystemCache.TodosEmpleados();
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

        public GestionEmpleados()
        {
            InitializeComponent();
        }

        SessionManager.Session _Sesion = SessionManager.Session.Instancia;

        private void GestionEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatos();

            if (!_Sesion.oUsuario.verificarPermiso("AGREGAR"))
            {
                btnAgregar.Visible = false;
            }
            if (!_Sesion.oUsuario.verificarPermiso("EDITAR"))
            {
                btnEditar.Visible = false;
            }
            if (!_Sesion.oUsuario.verificarPermiso("ELIMINAR"))
            {
                btnEliminar.Visible = false;
            }
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Usuarios.EdicionUsuarios f = Owner as Usuarios.EdicionUsuarios;

            f.txbIdPropietario.Text = dtgvDatos.CurrentRow.Cells["idempleado"].Value.ToString();
            f.txbPropietario.Text = dtgvDatos.CurrentRow.Cells["nombres"].Value.ToString() + " " + dtgvDatos.CurrentRow.Cells["apellidos"].Value.ToString();

            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionEmpleados f = new EdicionEmpleados();
            f.flpID.Visible = false;
            f.lblNombres.Margin = new Padding(3, 3, 3, 0);
            f.lblGenero.Margin = new Padding(3, 15, 3, 0);
            f.cmbGenero.Margin = new Padding(3, 5, 3, 3);
            f.lblDUI.Margin = new Padding(30, 0, 3, 0);
            f.txbDui.Margin = new Padding(30, 8, 3, 3);
            f.lblDepartamento.Margin = new Padding(30, 18, 3, 0);
            f.cmbDepartamento.Margin = new Padding(30, 3, 3, 3);
            f.lblMunicipio.Margin = new Padding(30, 0, 3, 0);
            f.txbMunicipio.Margin = new Padding(30, 10, 3, 3);
            f.cmbCargos.Margin = new Padding(30, 6, 3, 62);

            f.dtpContratacion.Text = null;
            f.dtpSalida.Text = null;
            f.lblIDpropietario.Text = dtgvDatos.Rows[0].Cells["idpropietario"].Value.ToString();
            f.lblContac.Text = dtgvDatos.Rows[0].Cells["idcontacto"].Value.ToString();
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
                    EdicionEmpleados f = new EdicionEmpleados();
                    DataTable idContactosAModificar = new DataTable();

                    f.lblContac.Text = dtgvDatos.Rows[0].Cells["idcontacto"].Value.ToString();

                    idContactosAModificar = CacheManager.SystemCache.IDContactosABorrarOModificarEmpleados(Convert.ToInt32(dtgvDatos.CurrentRow.Cells["idempleado"].Value.ToString()));

                    //Pasamos los contactos al dtgv de edición
                    for (int i = 0; i < int.Parse(idContactosAModificar.Rows.Count.ToString()); i++)
                    {
                        f._idContactos.Add(Convert.ToInt32(idContactosAModificar.Rows[i]["idcontacto"].ToString()));

                        DataRow row = f._Contactos.NewRow();

                        row["idcontacto"] = idContactosAModificar.Rows[i]["idcontacto"].ToString();
                        row["tipo"] = idContactosAModificar.Rows[i]["tipo"].ToString();
                        row["contacto"] = idContactosAModificar.Rows[i]["contacto"].ToString();
                        f._Contactos.Rows.Add(row);
                    }


                    //Sincronizando interfaz gráfica con registro seleccionado
                    //(Muestra los datos del registro a editar)
                    f.txbIDEmpleado.Text = dtgvDatos.CurrentRow.Cells["idempleado"].Value.ToString();
                    f.txbNombres.Text = dtgvDatos.CurrentRow.Cells["nombres"].Value.ToString();
                    f.txbApellidos.Text = dtgvDatos.CurrentRow.Cells["apellidos"].Value.ToString();
                    f.cmbGenero.SelectedValue = dtgvDatos.CurrentRow.Cells["genero"].Value.ToString();
                    f.dtpFechaNacimiento.Text = dtgvDatos.CurrentRow.Cells["fecha_nacimiento"].Value.ToString();
                    f.txbDui.Text = dtgvDatos.CurrentRow.Cells["dui"].Value.ToString();
                    f.txbNit.Text = dtgvDatos.CurrentRow.Cells["nit"].Value.ToString();
                    f.txbMunicipio.Text = dtgvDatos.CurrentRow.Cells["municipio"].Value.ToString();
                    f.txbDireccion.Text = dtgvDatos.CurrentRow.Cells["direccion"].Value.ToString();
                    f.cmbCargos.SelectedValue = dtgvDatos.CurrentRow.Cells["idcargo"].Value.ToString();
                    f.dtpContratacion.Text = dtgvDatos.CurrentRow.Cells["fechacontratacion"].Value.ToString();
                    f.dtpSalida.Text = dtgvDatos.CurrentRow.Cells["fechasalida"].Value.ToString();
                    f.cmbEstado.SelectedValue = dtgvDatos.CurrentRow.Cells["estado"].Value.ToString();
                    f.cmbDepartamento.SelectedValue = dtgvDatos.CurrentRow.Cells["iddepartamento"].Value.ToString();
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
                    int idempleado = Convert.ToInt32(dtgvDatos.CurrentRow.Cells["idempleado"].Value.ToString());

                    CLS.Empleados oEmpleado = new CLS.Empleados();
                    oEmpleado.Idempleado = idempleado;
                    if (oEmpleado.Eliminar())
                    {
                        //Si no tiene referencias de contactos se elimina directamente el registro
                        MessageBox.Show("Registro eliminado exitosamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    else
                    {
                        //En caso que si los tenga, preguntamos si desea continuar
                        if (MessageBox.Show("Si continua, se eliminaran los contactos asociados al registro", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CLS.Contactos oContacto = new CLS.Contactos();
                            CLS.ContactosEmpleados oContacEmpleado = new CLS.ContactosEmpleados();
                            DataTable idContactosAEliminar = new DataTable();

                            idContactosAEliminar = CacheManager.SystemCache.IDContactosABorrarOModificarEmpleados(idempleado);

                            //Eliminamos las referencias de contactos
                            oContacEmpleado.Idempleado = idempleado;
                            oContacEmpleado.Eliminar();

                            //Eliminamos los contactos
                            for (int i = 0; i < int.Parse(idContactosAEliminar.Rows.Count.ToString()); i++)
                            {
                                oContacto.Idcontacto = Convert.ToInt32(idContactosAEliminar.Rows[i]["idcontacto"].ToString());
                                oContacto.Eliminar();
                            }

                            //Eliminamos el registro
                            if (oEmpleado.Eliminar())
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
                        else
                        {
                            MessageBox.Show("El registro no pudo ser eliminado correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
    }
}
