using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using UI.Web.Filters;

namespace UI.Web.Controllers
{
    [TypeFilter(typeof(authFilter))]
    public class EspecialidadesController : Controller
    {
        public IActionResult Index()
        {
            TipoPersonas tp = Models.SessionHepler.GetTipoPersona(HttpContext.Session);
            ViewBag.tipo = tp.Descripcion;
            return View();
        }

        [HttpPost]
        public IActionResult nuevo(string descripcion1)
        {
            EspecialidadLogic eL = new EspecialidadLogic();
            Especialidad e = new Especialidad(0, descripcion1);
            try
            {
                eL.AddNew(e);
            }
            catch(Exception ex)
            {
                string msgerror = "No se registra la especialidad: " + ex.Message;
                ViewBag.msgerror = msgerror;
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
            
        }

        [HttpPost]
        public IActionResult guardarCambio(string IdEspecialidad2, string descripcion2)
        {
            EspecialidadLogic eL = new EspecialidadLogic();
            Especialidad e = new Especialidad(Convert.ToInt32(IdEspecialidad2), descripcion2);
            try
            {
                eL.SaveChanges(e);
            }
            catch(Exception ex)
            {
                string msgerror = "No se registra la especialidad: " + ex.Message;
                ViewBag.msgerror = msgerror;
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult borrar(string IdEspecialidad3)
        {
            EspecialidadLogic eL = new EspecialidadLogic();
            try
            {
                eL.Delete(Convert.ToInt32(IdEspecialidad3));
            }
            catch (Exception ex)
            {
                string msgerror = "No se registra la especialidad: " + ex.Message;
                ViewBag.msgerror = msgerror;
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
