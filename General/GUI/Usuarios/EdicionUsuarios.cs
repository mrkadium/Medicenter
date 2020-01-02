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
    public partial class EdicionUsuarios : Form
    {
        public int idPropietario;
        public String tipo;
        public String usuario;

        private void Procesar()
        {
            if (Verificacion() && txbIdUsuario.Text.Length <= 0)    //Si los campos están llenos y el id no tega nada es insertar
            {
                if (VerificacionTxbUsuario())       //Si el usuario q digite no es repetido al de la base 
                {

                    CLS.Usuarios oUsuarios = new CLS.Usuarios();
                    CLS.UsuariosMedicosEmpleados oUsuariosME = new CLS.UsuariosMedicosEmpleados();

                    oUsuarios.Usuario = txbUsuario.Text;
                    oUsuarios.Idrol = Convert.ToInt32(cmbRoles.SelectedValue.ToString());
                    if (rdbActivo.Checked == true)
                    {
                        oUsuarios.Estado = rdbActivo.Text;
                    }
                    else
                    {
                        oUsuarios.Estado = rdbBloqueado.Text;
                    }

                    if (VerificacionPass())
                    {
                        //INSERTANDO
                        if (oUsuarios.Guardar())
                        {
                            if (rdbEmpleado.Checked == true)
                            {
                                oUsuariosME.Idusuario = Convert.ToInt32(lblIdAInsertarReferencia.Text);
                                oUsuariosME.Idempleado = Convert.ToInt32(txbIdPropietario.Text);

                                oUsuariosME.GuardarUserEmpleado();
                            }
                            else
                            {
                                oUsuariosME.Idusuario = Convert.ToInt32(lblIdAInsertarReferencia.Text);
                                oUsuariosME.Idmedico = Convert.ToInt32(txbIdPropietario.Text);

                                oUsuariosME.GuardarUserMedico();
                            }


                            MessageBox.Show("Guardado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Registro no guardado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }   
                }
            }
            else if(Verificacion())
            {
                if(usuario == txbUsuario.Text)
                {

                    CLS.Usuarios oUsuarios = new CLS.Usuarios();
                    CLS.UsuariosMedicosEmpleados oUsuariosME = new CLS.UsuariosMedicosEmpleados();

                    oUsuarios.Usuario = txbUsuario.Text;
                    oUsuarios.Idrol = Convert.ToInt32(cmbRoles.SelectedValue.ToString());
                    if (rdbActivo.Checked == true)
                    {
                        oUsuarios.Estado = rdbActivo.Text;
                    }
                    else
                    {
                        oUsuarios.Estado = rdbBloqueado.Text;
                    }

                    //Si el campo de contraseña está vacío quiere decir q no quiere cambiar contraseña
                    if (txbPass.Text.Length == 0)
                    {
                        //Si el campo de confirmar contraseña tiene caracteres q los elimine
                        if (txbPassConfir.Text.Length == 0)
                        {
                            oUsuarios.Idusuario = Convert.ToInt32(txbIdUsuario.Text);

                            //ACTUALIZANDO
                            if (oUsuarios.ActualizarSinPass())
                            {
                                //*************************************** CHECK EMPLEADO ************************************
                                if (rdbEmpleado.Checked == true)
                                {
                                    //Si el anterior tambien era un empleado
                                    if (tipo == "Empleado")
                                    {
                                        if (idPropietario == Convert.ToInt32(txbIdPropietario.Text))
                                        {
                                            //Si es el mismo no pasa nada
                                        }
                                        else
                                        {
                                            //Sino, tenemos q eliminar la referencia anterior
                                            oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                            oUsuariosME.Idempleado = idPropietario;

                                            oUsuariosME.EliminarUserEmpleado();

                                            //Insertamos la nueva referencia
                                            oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                            oUsuariosME.Idempleado = Convert.ToInt32(txbIdPropietario.Text);

                                            oUsuariosME.GuardarUserEmpleado();
                                        }
                                    }
                                    else
                                    {
                                        //Si no era un empleado quiere decir q era un médico
                                        //Y tenemos q eliminar la referencia anterior
                                        oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                        oUsuariosME.Idmedico = idPropietario;

                                        oUsuariosME.EliminarUserMedico();

                                        //Insertamos la nueva referencia
                                        oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                        oUsuariosME.Idempleado = Convert.ToInt32(txbIdPropietario.Text);

                                        oUsuariosME.GuardarUserEmpleado();
                                    }
                                }
                                //****************************************************************************************
                                //▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼ CHECK MEDICO ▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼
                                else //Si no, quiere decir q está check en médico 
                                {
                                    //Si el anterior tambien era un médico
                                    if (tipo == "Medico")
                                    {
                                        if (idPropietario == Convert.ToInt32(txbIdPropietario.Text))
                                        {
                                            //Si es el mismo no pasa nada
                                        }
                                        else
                                        {
                                            //Sino, tenemos q eliminar la referencia anterior
                                            oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                            oUsuariosME.Idmedico = idPropietario;

                                            oUsuariosME.EliminarUserMedico();

                                            //Insertamos la nueva referencia
                                            oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                            oUsuariosME.Idmedico = Convert.ToInt32(txbIdPropietario.Text);

                                            oUsuariosME.GuardarUserMedico();
                                        }
                                    }
                                    else
                                    {
                                        //Si no era un médico quiere decir q era un empleado
                                        //Y tenemos q eliminar la referencia anterior
                                        oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                        oUsuariosME.Idempleado = idPropietario;

                                        oUsuariosME.EliminarUserEmpleado();

                                        //Insertamos la nueva referencia
                                        oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                        oUsuariosME.Idmedico = Convert.ToInt32(txbIdPropietario.Text);

                                        oUsuariosME.GuardarUserMedico();
                                    }
                                }
                                //▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲

                                MessageBox.Show("Editado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Registro no editado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Borre los caracteres de 'Confirmar contraseña'", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        //Si las contraseñas coinciden, se procede a actualizar con contraseña
                        if (txbPass.Text == txbPassConfir.Text)
                        {
                            oUsuarios.Credencial = txbPass.Text;
                            oUsuarios.Idusuario = Convert.ToInt32(txbIdUsuario.Text);

                            //ACTUALIZANDO
                            if (oUsuarios.ActualizarConPass())
                            {
                                //*************************************** CHECK EMPLEADO ************************************
                                if (rdbEmpleado.Checked == true)
                                {
                                    //Si el anterior tambien era un empleado
                                    if (tipo == "Empleado")
                                    {
                                        if (idPropietario == Convert.ToInt32(txbIdPropietario.Text))
                                        {
                                            //Si es el mismo no pasa nada
                                        }
                                        else
                                        {
                                            //Sino, tenemos q eliminar la referencia anterior
                                            oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                            oUsuariosME.Idempleado = idPropietario;

                                            oUsuariosME.EliminarUserEmpleado();

                                            //Insertamos la nueva referencia
                                            oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                            oUsuariosME.Idempleado = Convert.ToInt32(txbIdPropietario.Text);

                                            oUsuariosME.GuardarUserEmpleado();
                                        }
                                    }
                                    else
                                    {
                                        //Si no era un empleado quiere decir q era un médico
                                        //Y tenemos q eliminar la referencia anterior
                                        oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                        oUsuariosME.Idmedico = idPropietario;

                                        oUsuariosME.EliminarUserMedico();

                                        //Insertamos la nueva referencia
                                        oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                        oUsuariosME.Idempleado = Convert.ToInt32(txbIdPropietario.Text);

                                        oUsuariosME.GuardarUserEmpleado();
                                    }
                                }
                                //****************************************************************************************
                                //▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼ CHECK MEDICO ▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼
                                else //Si no, quiere decir q está check en médico 
                                {
                                    //Si el anterior tambien era un médico
                                    if (tipo == "Medico")
                                    {
                                        if (idPropietario == Convert.ToInt32(txbIdPropietario.Text))
                                        {
                                            //Si es el mismo no pasa nada
                                        }
                                        else
                                        {
                                            //Sino, tenemos q eliminar la referencia anterior
                                            oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                            oUsuariosME.Idmedico = idPropietario;

                                            oUsuariosME.EliminarUserEmpleado();

                                            //Insertamos la nueva referencia
                                            oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                            oUsuariosME.Idmedico = Convert.ToInt32(txbIdPropietario.Text);

                                            oUsuariosME.GuardarUserMedico();
                                        }
                                    }
                                    else
                                    {
                                        //Si no era un médico quiere decir q era un empleado
                                        //Y tenemos q eliminar la referencia anterior
                                        oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                        oUsuariosME.Idempleado = idPropietario;

                                        oUsuariosME.EliminarUserEmpleado();

                                        //Insertamos la nueva referencia
                                        oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                        oUsuariosME.Idmedico = Convert.ToInt32(txbIdPropietario.Text);

                                        oUsuariosME.GuardarUserMedico();
                                    }
                                }
                                //▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲

                                MessageBox.Show("Editado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Registro no editado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas no coinciden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    if (VerificacionTxbUsuario())
                    {

                        CLS.Usuarios oUsuarios = new CLS.Usuarios();
                        CLS.UsuariosMedicosEmpleados oUsuariosME = new CLS.UsuariosMedicosEmpleados();

                        oUsuarios.Usuario = txbUsuario.Text;
                        oUsuarios.Idrol = Convert.ToInt32(cmbRoles.SelectedValue.ToString());
                        if (rdbActivo.Checked == true)
                        {
                            oUsuarios.Estado = rdbActivo.Text;
                        }
                        else
                        {
                            oUsuarios.Estado = rdbBloqueado.Text;
                        }

                        //Si el campo de contraseña está vacío quiere decir q no quiere cambiar contraseña
                        if (txbPass.Text.Length == 0)
                        {
                            //Si el campo de confirmar contraseña tiene caracteres q los elimine
                            if (txbPassConfir.Text.Length == 0)
                            {
                                oUsuarios.Idusuario = Convert.ToInt32(txbIdUsuario.Text);

                                //ACTUALIZANDO
                                if (oUsuarios.ActualizarSinPass())
                                {
                                    //*************************************** CHECK EMPLEADO ************************************
                                    if (rdbEmpleado.Checked == true)
                                    {
                                        //Si el anterior tambien era un empleado
                                        if (tipo == "Empleado")
                                        {
                                            if (idPropietario == Convert.ToInt32(txbIdPropietario.Text))
                                            {
                                                //Si es el mismo no pasa nada
                                            }
                                            else
                                            {
                                                //Sino, tenemos q eliminar la referencia anterior
                                                oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                                oUsuariosME.Idempleado = idPropietario;

                                                oUsuariosME.EliminarUserEmpleado();

                                                //Insertamos la nueva referencia
                                                oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                                oUsuariosME.Idempleado = Convert.ToInt32(txbIdPropietario.Text);

                                                oUsuariosME.GuardarUserEmpleado();
                                            }
                                        }
                                        else
                                        {
                                            //Si no era un empleado quiere decir q era un médico
                                            //Y tenemos q eliminar la referencia anterior
                                            oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                            oUsuariosME.Idmedico = idPropietario;

                                            oUsuariosME.EliminarUserMedico();

                                            //Insertamos la nueva referencia
                                            oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                            oUsuariosME.Idempleado = Convert.ToInt32(txbIdPropietario.Text);

                                            oUsuariosME.GuardarUserEmpleado();
                                        }
                                    }
                                    //****************************************************************************************
                                    //▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼ CHECK MEDICO ▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼
                                    else //Si no, quiere decir q está check en médico 
                                    {
                                        //Si el anterior tambien era un médico
                                        if (tipo == "Medico")
                                        {
                                            if (idPropietario == Convert.ToInt32(txbIdPropietario.Text))
                                            {
                                                //Si es el mismo no pasa nada
                                            }
                                            else
                                            {
                                                //Sino, tenemos q eliminar la referencia anterior
                                                oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                                oUsuariosME.Idmedico = idPropietario;

                                                oUsuariosME.EliminarUserMedico();

                                                //Insertamos la nueva referencia
                                                oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                                oUsuariosME.Idmedico = Convert.ToInt32(txbIdPropietario.Text);

                                                oUsuariosME.GuardarUserMedico();
                                            }
                                        }
                                        else
                                        {
                                            //Si no era un médico quiere decir q era un empleado
                                            //Y tenemos q eliminar la referencia anterior
                                            oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                            oUsuariosME.Idempleado = idPropietario;

                                            oUsuariosME.EliminarUserEmpleado();

                                            //Insertamos la nueva referencia
                                            oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                            oUsuariosME.Idmedico = Convert.ToInt32(txbIdPropietario.Text);

                                            oUsuariosME.GuardarUserMedico();
                                        }
                                    }
                                    //▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲

                                    MessageBox.Show("Editado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("Registro no editado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Borre los caracteres de 'Confirmar contraseña'", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            //Si las contraseñas coinciden, se procede a actualizar con contraseña
                            if (txbPass.Text == txbPassConfir.Text)
                            {
                                oUsuarios.Credencial = txbPass.Text;
                                oUsuarios.Idusuario = Convert.ToInt32(txbIdUsuario.Text);

                                //ACTUALIZANDO
                                if (oUsuarios.ActualizarConPass())
                                {
                                    //*************************************** CHECK EMPLEADO ************************************
                                    if (rdbEmpleado.Checked == true)
                                    {
                                        //Si el anterior tambien era un empleado
                                        if (tipo == "Empleado")
                                        {
                                            if (idPropietario == Convert.ToInt32(txbIdPropietario.Text))
                                            {
                                                //Si es el mismo no pasa nada
                                            }
                                            else
                                            {
                                                //Sino, tenemos q eliminar la referencia anterior
                                                oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                                oUsuariosME.Idempleado = idPropietario;

                                                oUsuariosME.EliminarUserEmpleado();

                                                //Insertamos la nueva referencia
                                                oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                                oUsuariosME.Idempleado = Convert.ToInt32(txbIdPropietario.Text);

                                                oUsuariosME.GuardarUserEmpleado();
                                            }
                                        }
                                        else
                                        {
                                            //Si no era un empleado quiere decir q era un médico
                                            //Y tenemos q eliminar la referencia anterior
                                            oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                            oUsuariosME.Idmedico = idPropietario;

                                            oUsuariosME.EliminarUserMedico();

                                            //Insertamos la nueva referencia
                                            oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                            oUsuariosME.Idempleado = Convert.ToInt32(txbIdPropietario.Text);

                                            oUsuariosME.GuardarUserEmpleado();
                                        }
                                    }
                                    //****************************************************************************************
                                    //▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼ CHECK MEDICO ▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼
                                    else //Si no, quiere decir q está check en médico 
                                    {
                                        //Si el anterior tambien era un médico
                                        if (tipo == "Medico")
                                        {
                                            if (idPropietario == Convert.ToInt32(txbIdPropietario.Text))
                                            {
                                                //Si es el mismo no pasa nada
                                            }
                                            else
                                            {
                                                //Sino, tenemos q eliminar la referencia anterior
                                                oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                                oUsuariosME.Idmedico = idPropietario;

                                                oUsuariosME.EliminarUserEmpleado();

                                                //Insertamos la nueva referencia
                                                oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                                oUsuariosME.Idmedico = Convert.ToInt32(txbIdPropietario.Text);

                                                oUsuariosME.GuardarUserMedico();
                                            }
                                        }
                                        else
                                        {
                                            //Si no era un médico quiere decir q era un empleado
                                            //Y tenemos q eliminar la referencia anterior
                                            oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                            oUsuariosME.Idempleado = idPropietario;

                                            oUsuariosME.EliminarUserEmpleado();

                                            //Insertamos la nueva referencia
                                            oUsuariosME.Idusuario = Convert.ToInt32(txbIdUsuario.Text);
                                            oUsuariosME.Idmedico = Convert.ToInt32(txbIdPropietario.Text);

                                            oUsuariosME.GuardarUserMedico();
                                        }
                                    }
                                    //▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲

                                    MessageBox.Show("Editado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("Registro no editado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Las contraseñas no coinciden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
        }
        private Boolean Verificacion()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbUsuario.TextLength <= 0) { Verificado = false; Notificador.SetError(txbUsuario, "Este campo debe llenarse"); }
            if (txbPropietario.TextLength <= 0) { Verificado = false; Notificador.SetError(txbPropietario, "Este campo debe llenarse"); }

            return Verificado;
        }

        private Boolean VerificacionTxbUsuario()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (CacheManager.SystemCache.ValidarTxbUsuario(txbUsuario.Text)) { Verificado = false; Notificador.SetError(txbUsuario, "El usuario ya se encuentra en el sistema"); }

            return Verificado;
        }

        private Boolean VerificacionPass()
        {
            Boolean Verificado = true;
            Notificador.Clear();
            
            if (txbPass.TextLength <= 0) { Verificado = false; Notificador.SetError(txbPass, "Este campo debe llenarse"); }
            if (txbPassConfir.TextLength <= 0) { Verificado = false; Notificador.SetError(txbPassConfir, "Este campo debe llenarse"); }            

            return Verificado;
        }

        public EdicionUsuarios()
        {
            InitializeComponent();
            CargarRoles();
        }

        private void txbPassConfir_Leave(object sender, EventArgs e)
        {
            if (txbPass.Text != txbPassConfir.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

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

        private void ckbVerPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVerPass.Checked == true)
            {
                txbPass.PasswordChar = '\0';
            }
            else
            {
                txbPass.PasswordChar = Convert.ToChar("●");
            }
        }

        private void ckbVerPass2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVerPass2.Checked == true)
            {
                txbPassConfir.PasswordChar = '\0';
            }
            else
            {
                txbPassConfir.PasswordChar = Convert.ToChar("●");
            }
        }

        private void btnPropietario_Click(object sender, EventArgs e)
        {
            if (rdbEmpleado.Checked == false && rdbMedico.Checked == false)
            {
                MessageBox.Show("Selecciona una fuente para el contacto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rdbEmpleado.Checked == true)
                {
                    GUI.Empleados.GestionEmpleados f = new GUI.Empleados.GestionEmpleados();
                    AddOwnedForm(f);
                    f.btnAgregar.Visible = false;
                    f.btnEditar.Visible = false;
                    f.btnEliminar.Visible = false;
                    f.btnSeleccionar.Visible = true;
                    f.ShowDialog();
                }
                else
                {
                    GUI.Medicos.GestionMedicos f = new GUI.Medicos.GestionMedicos();
                    AddOwnedForm(f);
                    f.btnAgregar.Visible = false;
                    f.btnEditar.Visible = false;
                    f.btnEliminar.Visible = false;
                    f.btnSeleccionar.Visible = true;
                    f.TipoOperacion = 0;
                    f.ShowDialog();
                }
            }
        }

        private void rdbEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            txbPropietario.Clear();
            txbIdPropietario.Clear();
        }

        private void txbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSeparator(e.KeyChar))   //No permitir el espacio 
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void txbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void ckbVerPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (ckbVerPass.Checked == false)
                {
                    ckbVerPass.Checked = true;
                }
                else
                {
                    ckbVerPass.Checked = false;
                }
            }
        }

        private void txbPassConfir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Procesar();
            }
        }

        private void ckbVerPass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (ckbVerPass2.Checked == false)
                {
                    ckbVerPass2.Checked = true;
                }
                else
                {
                    ckbVerPass2.Checked = false;
                }
            }
        }

        private void cmbRoles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbRoles.DroppedDown == false)
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    Procesar();
                }
            }
        }

        private void rdbActivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (rdbActivo.Checked == false)
                {
                    rdbActivo.Checked = true;
                }
            }
        }

        private void rdbBloqueado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (rdbActivo.Checked == false)
                {
                    rdbActivo.Checked = true;
                }
            }
        }

        private void rdbEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (rdbEmpleado.Checked == false)
                {
                    rdbEmpleado.Checked = true;
                }
            }
        }

        private void rdbMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (rdbMedico.Checked == false)
                {
                    rdbMedico.Checked = true;
                }
            }
        }

        private void txbPropietario_KeyPress(object sender, KeyPressEventArgs e)
        {            
            e.Handled = true;   //el resto de teclas pulsadas se desactivan
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (rdbEmpleado.Checked == false && rdbMedico.Checked == false)
                {
                    MessageBox.Show("Selecciona una fuente para el contacto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (rdbEmpleado.Checked == true)
                    {
                        GUI.Empleados.GestionEmpleados f = new GUI.Empleados.GestionEmpleados();
                        AddOwnedForm(f);
                        f.btnAgregar.Visible = false;
                        f.btnEditar.Visible = false;
                        f.btnEliminar.Visible = false;
                        f.btnSeleccionar.Visible = true;
                        f.ShowDialog();
                    }
                    else
                    {
                        GUI.Medicos.GestionMedicos f = new GUI.Medicos.GestionMedicos();
                        AddOwnedForm(f);
                        f.btnAgregar.Visible = false;
                        f.btnEditar.Visible = false;
                        f.btnEliminar.Visible = false;
                        f.btnSeleccionar.Visible = true;
                        f.TipoOperacion = 0;
                        f.ShowDialog();
                    }
                }
            }
        }

        private void btnPropietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (rdbEmpleado.Checked == false && rdbMedico.Checked == false)
                {
                    MessageBox.Show("Selecciona una fuente para el contacto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (rdbEmpleado.Checked == true)
                    {
                        GUI.Empleados.GestionEmpleados f = new GUI.Empleados.GestionEmpleados();
                        AddOwnedForm(f);
                        f.btnAgregar.Visible = false;
                        f.btnEditar.Visible = false;
                        f.btnEliminar.Visible = false;
                        f.btnSeleccionar.Visible = true;
                        f.ShowDialog();
                    }
                    else
                    {
                        GUI.Medicos.GestionMedicos f = new GUI.Medicos.GestionMedicos();
                        AddOwnedForm(f);
                        f.btnAgregar.Visible = false;
                        f.btnEditar.Visible = false;
                        f.btnEliminar.Visible = false;
                        f.btnSeleccionar.Visible = true;
                        f.TipoOperacion = 0;
                        f.ShowDialog();
                    }
                }
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
