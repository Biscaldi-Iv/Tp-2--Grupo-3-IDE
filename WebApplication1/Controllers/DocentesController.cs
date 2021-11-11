using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Web.Controllers
{
    public class DocentesController : Controller
    {
        public IActionResult CargarNotas()
        {
            ViewBag.msgerror = "";
            if (TempData.ContainsKey("msgerror"))
            {
                ViewBag.msgerror = TempData["msgerror"].ToString();
            }
            AlumnoInscripcionLogic al = new AlumnoInscripcionLogic();
            UsuarioLogic ul = new UsuarioLogic();
            int id = Models.SessionHepler.GetUsuario(HttpContext.Session).IdPersona;
            List<AlumnoInscripcion> inscripciones = al.GetInscripciones_D(id);
            //ViewBag.inscripciones = inscripciones;
            var InscAlumnos = (from i in inscripciones
                               join p in ul.GetAll()
       on i.IDAlumno equals p.ID
                               select (i, p)).ToList();
            ViewBag.inscripciones = InscAlumnos;


            
            return View();
        }

        public IActionResult Cargar(int idalumnoinscripcio, int idalumno, int idcurso, string condicion, int nota)
        {
            //
            AlumnoInscripcion ai = new AlumnoInscripcion(idalumnoinscripcio, condicion, idalumno, idcurso, nota);
            AlumnoInscripcionLogic al = new AlumnoInscripcionLogic();
            try
            {
                al.Save(ai);
            }
            catch(Exception e)
            {
                TempData.Add("msgerror","Error al cargar la nota:" + e.Message);
            }
            return RedirectToAction("CargarNotas");
        }
    }
}
