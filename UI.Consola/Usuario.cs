using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Usuario
    {
        private UsuarioLogic user;
        public UsuarioLogic UsuarioNegocio
        {
            get { return this.user; }
            set { this.user = value; }
        }

        public Usuario(UsuarioLogic usr)
        {
            this.UsuarioNegocio = usr;
        }

        public static int menu()
        {
            Console.Write("\t\t1– Listado General\n" +
                "\t\t2– Consulta\n" +
                "\t\t3– Agregar\n" +
                "\t\t4 - Modificar\n" +
                "\t\t5 - Eliminar\n" +
                "\t\t6 - Salir\n" +
                "\n\n\t\tSeleccionar:");
            int s = int.Parse(Console.ReadLine());
            return s;
        }
        #region metodos_a_completar
        public void ListadoGeneral()
        {

        }

        public void Consultar()
        {

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

        public void MostrarDatos()
        {

        }
        #endregion
    }
}
