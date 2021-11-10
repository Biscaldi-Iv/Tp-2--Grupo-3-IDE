using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using Microsoft.AspNetCore.Authorization;

namespace UI.Web.Controllers
{
    [Authorize(Policy = "EstadoReq")]
    public class EspecialidadesController : Controller
    {
        public IActionResult Index()
        {
            TipoPersonas tp = Models.SessionHepler.GetTipoPersona(HttpContext.Session);
            ViewBag.tipo = tp.Descripcion;
            if (TempData.ContainsKey("msgerror"))
            {
                ViewBag.msgerror = TempData["msgerror"].ToString();
            }
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
                TempData.Remove("msgerror");
                TempData.Add("msgerror", msgerror);
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
                TempData.Remove("msgerror");
                TempData.Add("msgerror", msgerror);
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
                TempData.Remove("msgerror");
                TempData.Add("msgerror", msgerror);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
