using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;

namespace UI.Desktop
{
    static class Program
    {
        public static Usuario usuarioLog;
        public static TipoPersonas tipo;

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
            //Application.Run(new Planes());
            Application.Run(menu =new MenuPrincipal());
            //Application.Run(new Comisiones());

        }
    }
}
