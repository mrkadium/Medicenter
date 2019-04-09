using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionManager
{
    public class Session
    {
        static volatile Session _Instancia = null;
        static Object locker = new object();
        Usuario _oUsuario;

        public Usuario oUsuario { get => _oUsuario; set => _oUsuario = value; }

        public static Session Instancia
        {
            get
            {
                if(_Instancia == null)
                {
                    lock (locker)  //para que no sea multithreading
                    {
                        if(_Instancia == null)
                        {
                            _Instancia = new Session();
                        }
                    }
                }
                return _Instancia;
            }
        }

        private Session() {
            _oUsuario = new Usuario();
        }
    }
}
