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

        public bool menu()
        {
            Console.Clear();
            Console.Write("\t\t1– Listado General\n" +
                "\t\t2– Consulta\n" +
                "\t\t3– Agregar\n" +
                "\t\t4 - Modificar\n" +
                "\t\t5 - Eliminar\n" +
                "\t\tOtro - Salir\n" +
                "\n\n\t\tSeleccionar:");
            int s = int.Parse(Console.ReadLine());
            Console.Clear();
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
                default:return false;
            }
            Console.Write("\n\nPresione para continuar");
            Console.ReadKey();
            return true;
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

        public static string LectorClaves()
        {
            string key = "";
            ConsoleKey aux;
            do
            {
                aux = Console.ReadKey().Key;
                Console.Write("\b*");
                if (aux != ConsoleKey.Enter) key += aux.ToString();
            } while (aux != ConsoleKey.Enter);
            Console.Write("\n");
            return key;
        }

        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException e)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un numero entero");
            }
            catch (NullReferenceException e) 
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);

            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
         
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
           
            

        }

        public void Agregar()
        {
            Usuario usuario = new Usuario();
            Console.Clear();
            Console.Write("Ingrese Nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.Write("Ingrese Apellido: ");
            usuario.Apellido = Console.ReadLine();
            Console.Write("Ingrese Nombre de Usuario: ");
            usuario.NombreUsuario = Console.ReadLine();
            Console.Write("Ingrese Clave: ");
            usuario.Clave = Usuarios.LectorClaves();
            Console.Write("Ingrese Email: ");
            usuario.Email = Console.ReadLine();
            Console.Write("Ingrese Habilitacion de Usuario (1-Si/otro-No): ");
            usuario.Habilitado = (Console.ReadLine() == "1");
            usuario.State = BusinessEntity.States.Alta;
            UsuarioNegocio.Save(usuario);
            Console.WriteLine();
            Console.WriteLine("ID: {0}",usuario.ID);
        }

        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID  del usuario a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Usuario usuario = UsuarioNegocio.GetOne(ID);
                Console.Write("Ingrese Nombre: ");
                usuario.Nombre = Console.ReadLine();
                Console.Write("Ingrese Apellido: ");
                usuario.Apellido = Console.ReadLine();
                Console.Write("Ingrese Nombre de Usuario: ");
                usuario.NombreUsuario = Console.ReadLine();
                Console.Write("Ingrese Clave: ");
                usuario.Clave = Console.ReadLine();
                Console.Write("Ingrese Email: ");
                usuario.Email = Console.ReadLine();
                Console.Write("Ingrese Habilitacion de Usuario (1-si/otro-no): ");
                usuario.Habilitado = (Console.ReadLine() == "1");
                usuario.State = BusinessEntity.States.Modificado;
                UsuarioNegocio.Save(usuario);

            }
            catch (FormatException e)  
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un numero entero");                            
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }

        }

        public void Eliminar()
        {
            try {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a aeliminar: ");
                int ID = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(ID);
            }
            catch (FormatException e)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un numero entero");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);

            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }


        }

        #endregion
        
    }
}
