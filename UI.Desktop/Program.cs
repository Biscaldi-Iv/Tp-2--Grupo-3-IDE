using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static MenuPrincipal menu;
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Usuarios());
            //Application.Run(new FormListaEspecialidades());
<<<<<<< HEAD
            //Application.Run(new Planes());
            Application.Run(menu =new MenuPrincipal());
=======
             Application.Run(menu =new MenuPrincipal());
            //Application.Run(new Comisiones());

>>>>>>> cebbbaa9d2ca1deaf83f0ef615b14b610c149f56

        }
    }
}
