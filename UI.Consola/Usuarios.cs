using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Usuarios
    {
        private UsuarioLogic user;
        public UsuarioLogic UsuarioNegocio
        {
            get { return this.user; }
            set { this.user = value; }
        }

        public Usuarios()
        {
            this.UsuarioNegocio = new UsuarioLogic(new Data.Database.UsuarioAdapter());
        }

        public void menu()
        {
            Console.Write("\t\t1– Listado General\n" +
                "\t\t2– Consulta\n" +
                "\t\t3– Agregar\n" +
                "\t\t4 - Modificar\n" +
                "\t\t5 - Eliminar\n" +
                "\t\t6 - Salir\n" +
                "\n\n\t\tSeleccionar:");
            int s = int.Parse(Console.ReadLine());
            switch (s)
            {
                case 1:
                    this.ListadoGeneral();
                    break;
                case 2:
                    this.Consultar();
                    break;
                case 3:
                    this.Agregar();
                    break;
                case 4:
                    this.Modificar();
                    break;
                case 5:
                    this.Eliminar();
                    break;
                default:break;
            }
        }
        
        #region metodos_a_completar
        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Usuario user in UsuarioNegocio.GetAll())
            {
                MostrarDatos(user);
            }
        }

        public void MostrarDatos(Usuario usr)
        {
            Console.WriteLine("Usuario: {0}", usr.ID);
            Console.WriteLine("\t\tNombre: {0}", usr.Nombre);
            Console.WriteLine("\t\tApellido: {0}", usr.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: {0}", usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usr.Clave);
            Console.WriteLine("\t\tEmail: {0}", usr.Email);
            Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);
            Console.WriteLine();
        }

        public void Consultar()
        {
            Console.Clear();
            Console.Write("Ingrese el ID del usuario a consultar: ");
            int ID = int.Parse(Console.ReadLine());
            this.MostrarDatos(UsuarioNegocio.GetOne(ID));

        }

        public void Agregar()
        {

        }

        public void Modificar()
        {

        }

        public void Eliminar()
        {

        }

        #endregion
        
    }
}
