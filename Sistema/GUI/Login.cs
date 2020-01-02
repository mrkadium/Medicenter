using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Sistema.GUI
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {

        SessionManager.Session _SESION = SessionManager.Session.Instancia;
        //Atributo
        Boolean _Autorizado = false;
        //propiedad de solo lectura
        public Boolean Autorizado
        {
            get { return _Autorizado; }
            //set { _Autorizado = value; }
        }
        

        public Login()
        {
            InitializeComponent();
        }
        private void Validar(String pUsuario, String pCredencial)
        {
            DataTable DatosUsuario = new DataTable();
            DataTable DatosUsuarioMedico = new DataTable();
            DataTable Permisos = new DataTable();
            try
            {
                //PARA EMPLEADOS
                DatosUsuario = CacheManager.SystemCache.ValidarUsuario(pUsuario, pCredencial);
                //PARA MÉDICOS
                DatosUsuarioMedico = CacheManager.SystemCache.ValidarMedico(pUsuario, pCredencial);
                if (DatosUsuario.Rows.Count == 1)
                {
                    _Autorizado = true;
                    _SESION.oUsuario.IDUsuario = DatosUsuario.Rows[0]["idUsuario"].ToString();
                    _SESION.oUsuario.Usuario1 = DatosUsuario.Rows[0]["usuario"].ToString();
                    _SESION.oUsuario.Rol = DatosUsuario.Rows[0]["idRol"].ToString();
                    _SESION.oUsuario.IDRol = DatosUsuario.Rows[0]["rol"].ToString();
                    _SESION.oUsuario.IDEmpleado = DatosUsuario.Rows[0]["idEmpleado"].ToString();
                    _SESION.oUsuario.Empleado = DatosUsuario.Rows[0]["empleado"].ToString();

                    //PERMISOS DEL USUARIO
                    Permisos = CacheManager.SystemCache.getPermisosUsuario(DatosUsuario.Rows[0]["usuario"].ToString());
                    List<String> lista = new List<string>();
                    for (int i = 0; i < Permisos.Rows.Count; i++)
                    {
                        lista.Add(Permisos.Rows[i]["opcion"].ToString());
                    }
                    _SESION.oUsuario.Opciones = lista;
                    Close();
                }
                else if (DatosUsuarioMedico.Rows.Count == 1)
                {
                    _Autorizado = true;
                    _SESION.oUsuario.IDUsuario = DatosUsuarioMedico.Rows[0]["idUsuario"].ToString();
                    _SESION.oUsuario.Usuario1 = DatosUsuarioMedico.Rows[0]["usuario"].ToString();
                    _SESION.oUsuario.Rol = DatosUsuarioMedico.Rows[0]["idRol"].ToString();
                    _SESION.oUsuario.IDRol = DatosUsuarioMedico.Rows[0]["rol"].ToString();
                    _SESION.oUsuario.IDEmpleado = DatosUsuarioMedico.Rows[0]["jvpm"].ToString();
                    _SESION.oUsuario.Empleado = DatosUsuarioMedico.Rows[0]["medico"].ToString();

                    //PERMISOS DEL USUARIO
                    Permisos = CacheManager.SystemCache.getPermisosUsuario(DatosUsuarioMedico.Rows[0]["usuario"].ToString());
                    List<String> lista = new List<string>();
                    for (int i = 0; i < Permisos.Rows.Count; i++)
                    {
                        lista.Add(Permisos.Rows[i]["opcion"].ToString());
                    }
                    _SESION.oUsuario.Opciones = lista;
                    Close();
                }
                else
                {
                    _Autorizado = false;
                    lblMensaje.Text = "SU USUARIO Y/O SU CONTRASEÑA SON ERRÓNEOS";
                    SystemSounds.Asterisk.Play();
                }
                //Desing Patterns, Elements - GoF
            }
            catch
            {

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Environment.Exit(0);
        }
        

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSeparator(e.KeyChar))   //No Permitir el espacio 
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == (int)Keys.Enter || (int)e.KeyChar == ((int)Keys.Alt | (int)Keys.F4))
            {
                Validar(metroTextBox1.Text, metroTextBox2.Text);
            }
        }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keydata)
        {
            if (keydata == (Keys.Alt | Keys.F4))
            {
                Environment.Exit(0);
    
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keydata);
            }
        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Validar(metroTextBox1.Text, metroTextBox2.Text);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Validar(metroTextBox1.Text, metroTextBox2.Text);
        }

        private void Login_Load(object sender, EventArgs e)
        {

            this.Select();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
