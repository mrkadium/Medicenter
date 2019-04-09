using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.GUI
{
    public partial class Login : Form
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
            try
            {
                DatosUsuario = CacheManager.SystemCache.ValidarUsuario(pUsuario, pCredencial);
                if(DatosUsuario.Rows.Count == 1)
                {
                    _Autorizado = true;
                    _SESION.oUsuario.IDUsuario = DatosUsuario.Rows[0]["idUsuario"].ToString();
                    _SESION.oUsuario.Usuario1 = DatosUsuario.Rows[0]["usuario"].ToString();
                    _SESION.oUsuario.Rol = DatosUsuario.Rows[0]["rol"].ToString();
                    _SESION.oUsuario.IDRol = DatosUsuario.Rows[0]["idRol"].ToString();
                    _SESION.oUsuario.IDEmpleado = DatosUsuario.Rows[0]["idEmpleado"].ToString();
                    _SESION.oUsuario.Empleado = DatosUsuario.Rows[0]["empleado"].ToString();
                    Close();
                }
                else
                {
                    _Autorizado = false;
                    lblMensaje.Text = "SU USUARIO Y/O SU CONTRASEÑA SON ERRÓNEOS";
                }
                //Desing Patterns, Elements - GoF
            }
            catch
            {

            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Validar(txbUsuario.Text, txbCredencial.Text);

        }

        private void txbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                Validar(txbUsuario.Text, txbCredencial.Text);
            }
        }

        private void txbCredencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Validar(txbUsuario.Text, txbCredencial.Text);
            }
        }
    }
}
