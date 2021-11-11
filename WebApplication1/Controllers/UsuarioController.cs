using Business.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Logic;

namespace UI.Web.Controllers
{
    public class UsuarioController : Controller
    {
        
        public IActionResult Index()
        {
            if (TempData.ContainsKey("msgerror"))
            {
                ViewBag.msgerror = TempData["msgerror"].ToString();
            }
            TipoPersonas tp = Models.SessionHepler.GetTipoPersona(HttpContext.Session);
            ViewBag.tipo = tp.Descripcion;
            if (TempData.ContainsKey("msgerror"))
            {
                ViewBag.msgerror = TempData["msgerror"].ToString();
            }
            UsuarioLogic ul = new UsuarioLogic();
            PersonaLogic pl = new PersonaLogic();
            PlanesLogic planes  =  new PlanesLogic();
            TipoPersonaLogic tpl  =  new TipoPersonaLogic();
            ViewBag.Usuarios = ul.GetAll();
            ViewBag.Personas=pl.GetAll();
            ViewBag.Tipos  =  tpl.GetAll();
            ViewBag.Planes  =  planes.GetAll();
            return View();
        }

        public IActionResult RegistrarUsuario(string email1, string nombreusuario1, string clave1,
            string nombre1, string apellido1, int idpersona1)
        {
            UsuarioLogic ul = new UsuarioLogic();
            Usuario u = new Usuario(0,  nombreusuario1,  clave1,  nombre1,  apellido1,  email1,  true,  idpersona1,  true);
            ul.AddNew(u);
            return RedirectToAction("Index");

        }

        public IActionResult RegistrarUsuario2(string email1, string nombreusuario1, string clave1,
            string nombre1, string apellido1, string telefono1, DateTime fechanacimiento1,
            string legajo1, int idpersona1, string direccion1, int plan1, int tipo1)
        {
            UsuarioLogic ul = new UsuarioLogic();
            PersonaLogic pl  =  new PersonaLogic();
            Usuario u = new Usuario(0, nombreusuario1, clave1, nombre1, apellido1, email1,  true, idpersona1, true);
            Persona p = new Persona(0, nombreusuario1, apellido1, direccion1, email1, telefono1, fechanacimiento1, Convert.ToInt32(legajo1), tipo1, plan1 );
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id2,string email2, string nombreusuario2, string clave2,
            string nombre2, string apellido2, string telefono2, DateTime fechanacimiento2,
            string legajo2, int idpersona2, string direccion2, int plan2, int tipo2)
        {
            UsuarioLogic ul = new UsuarioLogic();
            PersonaLogic pl = new PersonaLogic();
            Usuario u = new Usuario(id2, nombreusuario2, clave2, nombre2, apellido2, email2, true, idpersona2, true);
            Persona p = new Persona(idpersona2, nombreusuario2, apellido2, direccion2, email2, telefono2, fechanacimiento2, Convert.ToInt32(legajo2), tipo2, plan2);

            try
            {
                ul.Save(u);
                pl.SaveChange(p);
            }
            catch (Exception e)
            {
                TempData.Add("msgerror", "NO se guardaron cambios "  +  e.Message);
            }
            return RedirectToAction("Index");

        }
        public IActionResult Eliminar(int id3)
        {
            UsuarioLogic ul = new UsuarioLogic();
            try
            {
                ul.Delete(id3);
            }
            catch(Exception e)
            {
                TempData.Add("msgerror",  "No se elimino al usuario"  +  e.Message);
            }
            
            return RedirectToAction("Index");
        }
    }
}
