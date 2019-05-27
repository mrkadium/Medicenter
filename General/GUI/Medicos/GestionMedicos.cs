using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Medicos
{
    public partial class GestionMedicos : Form
    {
        BindingSource _Medicos = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _Medicos.DataSource = CacheManager.SystemCache.TodosMedicos();
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
                    _Medicos.Filter = "nombres LIKE '%" + txbFiltro.Text + "%' OR apellidos LIKE '%" + txbFiltro.Text + "%'";
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
                else
                {
                    _Medicos.RemoveFilter();
                    dtgvDatos.AutoGenerateColumns = false;
                    dtgvDatos.DataSource = _Medicos;
                    lblRegistros.Text = dtgvDatos.Rows.Count.ToString() + " Registros encontrados";
                }
            }
            catch { }
        }

        public GestionMedicos()
        {
            InitializeComponent();
        }

        private void GestionMedicos_Load(object sender, EventArgs e)
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
            EdicionMedicos f = new EdicionMedicos();
            f.dtpContratacion.Text = null;
            f.dtpSalida.Text = null;
            f.lblIDpropietario.Text = dtgvDatos.Rows[0].Cells["idpropietario"].Value.ToString();
            f.lblContac.Text = dtgvDatos.Rows[0].Cells["idcontacto"].Value.ToString();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {                
                EdicionMedicos f = new EdicionMedicos();
                DataTable idContactosAModificar = new DataTable();
                DataTable idEspecialidadesAModificar = new DataTable();

                f.lblContac.Text = dtgvDatos.Rows[0].Cells["idcontacto"].Value.ToString();

                idContactosAModificar = CacheManager.SystemCache.IDContactosABorrarOModificar(Convert.ToInt32(dtgvDatos.CurrentRow.Cells["idmedico"].Value.ToString()));
                idEspecialidadesAModificar = CacheManager.SystemCache.EspecialidadesAModificar(Convert.ToInt32(dtgvDatos.CurrentRow.Cells["idmedico"].Value.ToString()));

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

                //Pasamos las especialidades al dtgv de edición
                for (int i = 0; i < int.Parse(idEspecialidadesAModificar.Rows.Count.ToString()); i++)
                {
                    f._idEspecialidades.Add(Convert.ToInt32(idEspecialidadesAModificar.Rows[i]["idespecialidad"].ToString()));

                    DataRow row = f._Especialidades.NewRow();

                    row["idespecialidad"] = idEspecialidadesAModificar.Rows[i]["idespecialidad"].ToString();
                    row["especialidad"] = idEspecialidadesAModificar.Rows[i]["especialidad"].ToString();
                    f._Especialidades.Rows.Add(row);
                }

                //Sincronizando interfaz gráfica con registro seleccionado
                //(Muestra los datos del registro a editar)
                f.txbIDMedico.Text = dtgvDatos.CurrentRow.Cells["idmedico"].Value.ToString();
                f.txbJVPM.Text = dtgvDatos.CurrentRow.Cells["jvpm"].Value.ToString();
                f.txbNombres.Text = dtgvDatos.CurrentRow.Cells["nombres"].Value.ToString();
                f.txbApellidos.Text = dtgvDatos.CurrentRow.Cells["apellidos"].Value.ToString();
                f.cmbGenero.SelectedValue = dtgvDatos.CurrentRow.Cells["genero"].Value.ToString();
                f.dtpFechaNacimiento.Text = dtgvDatos.CurrentRow.Cells["fecha_nacimiento"].Value.ToString();
                f.txbMunicipio.Text = dtgvDatos.CurrentRow.Cells["municipio"].Value.ToString();
                f.txbDireccion.Text = dtgvDatos.CurrentRow.Cells["Direcc"].Value.ToString();
                f.txbDui.Text = dtgvDatos.CurrentRow.Cells["dui"].Value.ToString();
                f.txbNit.Text = dtgvDatos.CurrentRow.Cells["nit"].Value.ToString();
                f.dtpContratacion.Text = dtgvDatos.CurrentRow.Cells["contratacion"].Value.ToString();
                f.dtpSalida.Text = dtgvDatos.CurrentRow.Cells["salida"].Value.ToString();
                f.cmbEstado.SelectedValue = dtgvDatos.CurrentRow.Cells["estado"].Value.ToString();
                f.cmbDepartamento.SelectedValue = dtgvDatos.CurrentRow.Cells["iddepartamento"].Value.ToString();
                f.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idmedico = Convert.ToInt32(dtgvDatos.CurrentRow.Cells["idmedico"].Value.ToString());

                CLS.Medicos oMedico = new CLS.Medicos();
                oMedico.Idmedico = idmedico;
                if (oMedico.Eliminar())
                {
                    //Sino tiene contactos asociados se elimina directamente el registro
                    MessageBox.Show("Registro eliminado exitosamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else
                {   
                    //En caso que si los tenga, preguntamos si desea continuar
                    if (MessageBox.Show("Si continua, se eliminaran los contactos asociados al registro", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CLS.Contactos oContacto = new CLS.Contactos();
                        CLS.ContactosMedicos oContacMedico = new CLS.ContactosMedicos();
                        CLS.EspecialidadesMedicos oEspecialidades = new CLS.EspecialidadesMedicos();
                        DataTable idContactosAEliminar = new DataTable();

                        idContactosAEliminar = CacheManager.SystemCache.IDContactosABorrarOModificar(idmedico);

                        //Eliminamos las asociaciones de contactos
                        oContacMedico.Idmedico = idmedico;
                        oContacMedico.Eliminar();

                        //Eliminamos los contactos
                        for (int i = 0; i < int.Parse(idContactosAEliminar.Rows.Count.ToString()); i++)
                        {
                            oContacto.Idcontacto = Convert.ToInt32(idContactosAEliminar.Rows[i]["idcontacto"].ToString());
                            oContacto.Eliminar();
                        }

                        //Eliminamos las asociaciones de especialidades
                        oEspecialidades.Idmedico = idmedico;
                        oEspecialidades.Eliminar();

                        //Eliminamos el registro
                        if (oMedico.Eliminar())
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
