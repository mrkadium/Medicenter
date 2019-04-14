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

            return autorizado;
        }
        public AppManager()
        {
            Splash();
            if (Login())
            {
                GUI.Principal f = new GUI.Principal();
                f.ShowDialog();
            }
            else
            {

            }
        }
    }
}
