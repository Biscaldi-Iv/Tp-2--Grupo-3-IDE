using System;


namespace UI.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            while (menu()) { } //ejecuta el menu de la clase program
        }

        public static bool menu()
        {
            Usuarios usersUI = new Usuarios();
            Console.Write("\n\n\t\t1– ABMC Usuarios\n" +
                "\t\t2- ABMC Especialidades - Salir\n" +
                "\t\tOtro - Salir\n" +
                "\n\n\t\tSeleccionar:");
            int s = int.Parse(Console.ReadLine());
            switch (s)
            {
                case 1: //ejecuta el menu de la clase usuario
                    while (usersUI.menu()) { }
                    break;
                default: return false;
            }
            return true;
        }


    }
}
