using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Sistema.CLS
{
    class AppManager:ApplicationContext
    {
        

        private void Splash()
        {
            GUI.Splash f = new GUI.Splash();
            f.ShowDialog();
        }
        private Boolean Login()
        {
            Boolean autorizado = false;
            GUI.Login f = new GUI.Login();
            f.ShowDialog();
            autorizado = f.Autorizado;
            f.Dispose();            
            return autorizado;
        }
        public AppManager()
        {
            Boolean Reinicio = true;
            Splash();
            do
            {
                if (Login())
                {
                    GUI.Principal f = new GUI.Principal();
                    f.ShowDialog();
                    Reinicio = f.Reinicio;
                    f.Dispose();
                }
            } while (!Reinicio);

            //Splash();
            //if (Login())
            //{
            //    GUI.Principal f = new GUI.Principal();
            //    f.ShowDialog();
            //}
        }
    }
}
