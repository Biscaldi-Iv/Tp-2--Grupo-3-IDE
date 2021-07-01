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
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new formMain());

            //Application.Run(new Usuarios());
=======
            //Application.Run(new UsuarioDesktop());
            Application.Run(new Usuarios());
>>>>>>> 579e7f56615a206e888f947621bb7041dfe3153b
        }
    }
}
