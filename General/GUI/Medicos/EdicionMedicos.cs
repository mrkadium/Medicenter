using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Medicos
{
    public partial class EdicionMedicos : Form
    {
        public DataTable _Contactos = new DataTable();
        public DataTable _Especialidades = new DataTable();
        public List<int> _idContactos = new List<int>();
        public List<int> _idEspecialidades = new List<int>();

        private void Procesar()
        {
            if (Verificacion() && VerificacionTxbDui() && VerificacionTxbNit())
            {
                CLS.Medicos oMedico = new CLS.Medicos();
                CLS.Contactos oContacto = new CLS.Contactos();
                CLS.ContactosMedicos oContactoMedico = new CLS.ContactosMedicos();
                CLS.EspecialidadesMedicos oEspecialidadesMedicos = new CLS.EspecialidadesMedicos();

                oMedico.Jvpm = Convert.ToInt32(txbJVPM.Text);
                oMedico.Nombres = txbNombres.Text;
                oMedico.Apellidos = txbApellidos.Text;
                oMedico.Genero = cmbGenero.SelectedValue.ToString();
                oMedico.FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Text);
                oMedico.Municipio = txbMunicipio.Text;
                oMedico.Direccion = txbDireccion.Text;
                oMedico.Dui = txbDui.Text;
                oMedico.Nit = txbNit.Text;

                if (dtpContratacion.Checked)
                {
                    oMedico.FechaContratacion = Convert.ToDateTime(dtpContratacion.Text);
                }
                else
                {
                    oMedico.FContratacionNula = "null";
                }

                if (dtpSalida.Checked)
                {
                    oMedico.FechaSalida = Convert.ToDateTime(dtpSalida.Text);
                }
                else
                {
                    oMedico.FSalidaNula = "null";
                }

                oMedico.Estado = cmbEstado.SelectedValue.ToString();
                oMedico.IdDepartamento = Convert.ToInt32(cmbDepartamento.SelectedValue.ToString());

                if (txbIDMedico.Text.Length == 0)
                {
                    int cont = 0;                  

                    //INSERTANDO
                    if (oMedico.Guardar())
                    {
                        //Verificando si hay contactos agregados
                        if (int.Parse(dtgvDatosContactos.Rows.Count.ToString()) > 0 || int.Parse(dtgvDatosEspecialidad.Rows.Count.ToString()) > 0)
                        {
                            //*********************************************** CONTACTOS ***************************************

                            //Si hay, los insertamos
                            for (int f = 0; f < int.Parse(dtgvDatosContactos.Rows.Count.ToString()); f++)
                            {
                                oContacto.Tipo = dtgvDatosContactos.Rows[f].Cells[1].Value.ToString();
                                oContacto.Contacto = dtgvDatosContactos.Rows[f].Cells[2].Value.ToString();

                                oContacto.Guardar();
                                cont++;
                            }

                            int contContactosAsig = 0;

                            //Asignamos los contactos creados al médico q acabamos de agregar
                            for (int g = 0; g < cont; g++)
                            {
                                oContactoMedico.Idcontacto = (Convert.ToInt32(lblContac.Text)) + contContactosAsig;
                                oContactoMedico.Idmedico = Convert.ToInt32(lblIDpropietario.Text);

                                oContactoMedico.Guardar();
                                contContactosAsig++;
                            }
                        }

                        //********************************************************************************************************

                        //▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼ ESPECIALIDADES ▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼

                        //Verificando si hay especialidades agregadas
                        if (int.Parse(dtgvDatosEspecialidad.Rows.Count.ToString()) > 0)
                        {
                            //Asignamos las especialidades a los médicos
                            for (int g = 0; g < int.Parse(dtgvDatosEspecialidad.Rows.Count.ToString()); g++)
                            {
                                oEspecialidadesMedicos.Idespecialidad = Convert.ToInt32(dtgvDatosEspecialidad.Rows[g].Cells[0].Value.ToString());
                                oEspecialidadesMedicos.Idmedico = Convert.ToInt32(lblIDpropietario.Text);

                                oEspecialidadesMedicos.Guardar();
                            }
                        }

                        //▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲
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
                    int cont = 0;
                    oMedico.Idmedico = Convert.ToInt32(txbIDMedico.Text);                    

                    //ACTUALIZANDO
                    if (oMedico.Actualizar())
                    {
                        //************************************************* CONTACTOS ************************************************

                        //Recorremos todos los registros
                        for (int x = 0; x < int.Parse(dtgvDatosContactos.Rows.Count.ToString()); x++)
                        {
                            //Validamos si contiene algo la celda
                            if (dtgvDatosContactos.Rows[x].Cells[0].Value.ToString() == "")
                            {
                                //En este caso no contiene nada por lo que es un contacto nuevo y debemos insertarlo
                                oContacto.Tipo = dtgvDatosContactos.Rows[x].Cells[1].Value.ToString();
                                oContacto.Contacto = dtgvDatosContactos.Rows[x].Cells[2].Value.ToString();

                                oContacto.Guardar();
                                cont++;
                            }
                        }

                        //Recorremos la lista para eliminar los contactos desechados
                        for(int y = 0; y < _idContactos.Count; y++)
                        {
                            int can2 = 0;

                            //Recorremos los contactos que quedaron en el dtgv
                            for (int h = 0; h < int.Parse(dtgvDatosContactos.Rows.Count.ToString()); h++)
                            {
                                if (dtgvDatosContactos.Rows[h].Cells[0].Value.ToString() == "")
                                {

                                }
                                else
                                {
                                    //Si lo q hay en la lista y lo q hay en el dtgv son iguales
                                    if (_idContactos[y] == Convert.ToInt32(dtgvDatosContactos.Rows[h].Cells[0].Value.ToString()))
                                    {
                                        can2++;
                                    }
                                }
                            }  
                            //Si esto es igual a 0 quiere decir q no se escontro en el dtgv
                            //Por lo tanto tenemos q eliminarlo
                            if(can2 == 0)
                            {
                                //Eliminanos la asociacion
                                oContactoMedico.Idcontacto = _idContactos[y];
                                oContactoMedico.Idmedico = Convert.ToInt32(txbIDMedico.Text);
                                oContactoMedico.EliminarPorContacto();

                                //Eliminanos el contacto
                                oContacto.Idcontacto = _idContactos[y];
                                oContacto.Eliminar();
                            }
                        }

                        int contContactosAsig = 0;

                        //Asignamos los contactos creados al médico q acabamos de agregar
                        for (int g = 0; g < cont; g++)
                        {
                            oContactoMedico.Idcontacto = (Convert.ToInt32(lblContac.Text)) + contContactosAsig;
                            oContactoMedico.Idmedico = Convert.ToInt32(txbIDMedico.Text);

                            oContactoMedico.Guardar();
                            contContactosAsig++;
                        }

                        //*********************************************************************************************************

                        //▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼ ESPECIALIDADES ▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼

                        //Recorremos la lista de especialidades
                        for (int y = 0; y < _idEspecialidades.Count; y++)
                        {
                            int can2 = 0;

                            //Recorremos las especialidades que quedaron en el dtgv
                            for (int h = 0; h < int.Parse(dtgvDatosEspecialidad.Rows.Count.ToString()); h++)
                            {
                                //Si lo q hay en la lista y lo q hay en el dtgv son iguales
                                if (_idEspecialidades[y] == Convert.ToInt32(dtgvDatosEspecialidad.Rows[h].Cells[0].Value.ToString()))
                                {
                                    can2++;
                                }
                            }
                            //Si esto es igual a 0 quiere decir q no se escontro en el dtgv
                            //Por lo tanto tenemos q eliminarlo
                            if (can2 == 0)
                            {
                                //Eliminanos la asociacion
                                oEspecialidadesMedicos.Idespecialidad = _idEspecialidades[y];
                                oEspecialidadesMedicos.Idmedico = Convert.ToInt32(txbIDMedico.Text);
                                oEspecialidadesMedicos.EliminarPorEspecialidad();
                            }
                        }

                        //Recorremos la lista de especialidades
                        for (int y = 0; y < int.Parse(dtgvDatosEspecialidad.Rows.Count.ToString()); y++)
                        {
                            int can2 = 0;
                                
                            //Recorremos las especialidades que quedaron en el dtgv
                            for (int h = 0; h < _idEspecialidades.Count; h++)
                            {
                                //Si lo q hay en la lista y lo q hay en el dtgv son iguales
                                if (_idEspecialidades[h] == Convert.ToInt32(dtgvDatosEspecialidad.Rows[y].Cells[0].Value.ToString()))
                                {
                                    can2++;
                                }
                            }
                            //Si esto es igual a 0 quiere decir q no se escontro en la lista
                            //Por lo tanto tenemos q add la nueva asociacion
                            if (can2 == 0)
                            {
                                //Add la asociacion
                                oEspecialidadesMedicos.Idespecialidad = Convert.ToInt32(dtgvDatosEspecialidad.Rows[y].Cells[0].Value.ToString());
                                oEspecialidadesMedicos.Idmedico = Convert.ToInt32(txbIDMedico.Text);

                                oEspecialidadesMedicos.Guardar();
                            }
                        }

                        //▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲

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

            if (txbJVPM.TextLength <= 0) { Verificado = false; Notificador.SetError(txbJVPM, "Este campo debe llenarse"); }
            if (txbNombres.TextLength <= 0) { Verificado = false; Notificador.SetError(txbNombres, "Este campo debe llenarse"); }
            if (txbApellidos.TextLength <= 0) { Verificado = false; Notificador.SetError(txbApellidos, "Este campo debe llenarse"); }
            if (txbMunicipio.TextLength <= 0) { Verificado = false; Notificador.SetError(txbMunicipio, "Este campo debe llenarse"); }
            if (txbDireccion.TextLength <= 0) { Verificado = false; Notificador.SetError(txbDireccion, "Este campo debe llenarse"); }      

            return Verificado;
        }

        private Boolean VerificacionTxbDui()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbDui.Text == "        -")
            {
                Verificado = false;
                Notificador.SetError(txbDui, "Este campo debe llenarse");
            }
            else
            {
                if (!txbDui.MaskFull)
                {
                    Verificado = false;
                    Notificador.SetError(txbDui, "Campo incompleto");
                }
            }

            return Verificado;
        }

        private Boolean VerificacionTxbNit()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbNit.Text == "    -      -   -")
            {
                Verificado = false;
                Notificador.SetError(txbNit, "Este campo debe llenarse");
            }
            else
            {
                if (!txbNit.MaskFull)
                {
                    Verificado = false;
                    Notificador.SetError(txbNit, "Campo incompleto");
                }
            }

            return Verificado;
        }

        public static bool IsValidEmail(string Email)
        {
            String strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);

            if (re.IsMatch(Email))
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        private Boolean VerificacionEmail()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbContacto.Text.Length <= 0)
            {
                Verificado = true;
            }
            else
            {
                if (!IsValidEmail(txbContacto.Text))
                {
                    Verificado = false;
                    Notificador.SetError(txbContacto, "El formato correcto es 'ejemplo@dominio.com'");
                }
            }

            return Verificado;
        }

        public EdicionMedicos()
        {
            InitializeComponent();
            CargarEstados();
            CargarGeneros();
            CargarDepartamentos();
            CargarFContratacion();
            CargarFSalida();
            CargarTiposContactos();
            CrearColumnasContactos();
            CrearColumnasEspecialidades();
        }

        private void CrearColumnasContactos()
        {
            _Contactos.Columns.Add("idcontacto");
            _Contactos.Columns.Add("tipo");
            _Contactos.Columns.Add("contacto");
            dtgvDatosContactos.DataSource = _Contactos;
        }

        private void CrearColumnasEspecialidades()
        {
            _Especialidades.Columns.Add("idespecialidad");
            _Especialidades.Columns.Add("especialidad");
            dtgvDatosEspecialidad.DataSource = _Especialidades;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void CargarEstados()
        {
            cmbEstado.DataSource = CLS.cmbEstados.Estados();
            cmbEstado.DisplayMember = "Dmember";
            cmbEstado.ValueMember = "Vmember";
        }

        private void CargarGeneros()
        {
            cmbGenero.DataSource = CLS.cmbEstados.Generos();
            cmbGenero.DisplayMember = "Dmember";
            cmbGenero.ValueMember = "Vmember";
        }

        private void CargarDepartamentos()
        {
            cmbDepartamento.DataSource = CacheManager.SystemCache.TodosDepartamentos();
            cmbDepartamento.DisplayMember = "departamento";
            cmbDepartamento.ValueMember = "iddepartamento";
        }

        private void CargarFContratacion()
        {
            if (dtpContratacion.Text == "null")
            {
                dtpContratacion.Checked = false;
            }
            else
            {
                dtpContratacion.Checked = true;
            }
        }

        private void CargarFSalida()
        {
            if (dtpSalida.Text == "null")
            {
                dtpSalida.Checked = false;
            }
            else
            {
                dtpSalida.Checked = true;
            }
        }
        
        private void CargarTiposContactos()
        {
            cmbTipo.DataSource = CLS.cmbEstados.TipoContacto();
            cmbTipo.DisplayMember = "Dmember";
            cmbTipo.ValueMember = "Vmember";
        }

        private Boolean VerificacionAddContactos()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbContacto.TextLength <= 0) { Verificado = false; Notificador.SetError(txbContacto, "Este campo debe llenarse"); }

            return Verificado;
        }

        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedValue.ToString() == "TELEFONO")
            {
                AddContact();
            }
            else
            {
                if (VerificacionEmail())
                {
                    AddContact();
                }
            }
        }

        private void AddContact()
        {
            if (VerificacionAddContactos())
            {
                DataRow row = _Contactos.NewRow();

                row["tipo"] = cmbTipo.SelectedValue.ToString();
                row["contacto"] = txbContacto.Text;
                _Contactos.Rows.Add(row);
            }
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            if (dtgvDatosContactos.CurrentRow == null)
            {
                return;
            }
            else
            {
                dtgvDatosContactos.Rows.Remove(dtgvDatosContactos.CurrentRow);
            }
        }

        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            Especialidades.GestionEspecialidades f = new Especialidades.GestionEspecialidades();
            AddOwnedForm(f);
            f.btnSeleccionar.Visible = true;
            f.btnAgregar.Visible = false;
            f.btnEditar.Visible = false;
            f.btnEliminar.Visible = false;
            f.ShowDialog();
        }
        
        private void btnEliminarEspecialidad_Click(object sender, EventArgs e)
        {
            if (dtgvDatosEspecialidad.CurrentRow == null)
            {
                return;
            }
            else
            {
                dtgvDatosEspecialidad.Rows.Remove(dtgvDatosEspecialidad.CurrentRow);
            }
        }

        private void txbJVPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void txbContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si presiona Enter en el txbContacto add el contacto al dtgv
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (cmbTipo.SelectedValue.ToString() == "TELEFONO")
                {
                    AddContact();
                }
                else
                {
                    if (VerificacionEmail())
                    {
                        AddContact();
                    }
                }
            }
        }

        private void txbDui_Leave(object sender, EventArgs e)
        {
            VerificacionTxbDui();
        }

        private void txbNit_Leave(object sender, EventArgs e)
        {
            VerificacionTxbNit();
        }

        private void txbNombres_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void txbApellidos_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void dtpFechaNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void dtpContratacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (dtpContratacion.Checked == false)
                {
                    dtpContratacion.Checked = true;
                }
                else
                {
                    Procesar();
                }
            }
        }

        private void cmbGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbGenero.DroppedDown == false)
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    Procesar();
                }
            }
        }

        private void txbDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void txbNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void cmbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbEstado.DroppedDown == false)
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    Procesar();
                }
            }
        }

        private void dtpSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (dtpSalida.Checked == false)
                {
                    dtpSalida.Checked = true;
                }
                else
                {
                    Procesar();
                }
            }
        }

        private void cmbDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbDepartamento.DroppedDown == false)
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    Procesar();
                }
            }
        }

        private void txbMunicipio_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void btnGuardar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnAgregarEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Especialidades.GestionEspecialidades f = new Especialidades.GestionEspecialidades();
                AddOwnedForm(f);
                f.btnSeleccionar.Visible = true;
                f.ShowDialog();
            }
        }

        private void cmbGenero_Enter(object sender, EventArgs e)
        {
            cmbGenero.DroppedDown = true;
        }

        private void cmbEstado_Enter(object sender, EventArgs e)
        {
            cmbEstado.DroppedDown = true;
        }

        private void cmbDepartamento_Enter(object sender, EventArgs e)
        {
            cmbDepartamento.DroppedDown = true;
        }

        private void cmbTipo_Enter(object sender, EventArgs e)
        {
            cmbTipo.DroppedDown = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
