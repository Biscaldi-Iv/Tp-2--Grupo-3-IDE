using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Web.Filters;
using Business.Entities;
using Business.Logic;

namespace UI.Web.Controllers
{
    [TypeFilter(typeof(authFilter))]
    public class PlanesController : Controller
    {
        public IActionResult Index()
        {
            TipoPersonas tp = Models.SessionHepler.GetTipoPersona(HttpContext.Session);
            ViewBag.tipo = tp.Descripcion;

            PlanesLogic plog = new PlanesLogic();
            EspecialidadLogic elog = new EspecialidadLogic();
            var planes = from pl in plog.GetAll()
                         join esp in elog.GetAll() on pl.IDEspecialidad equals esp.ID
                         select (pl.ID, pl.Descripcion, esp.Descripcion);
            ViewBag.planes = planes;
            ViewBag.especialidades = elog.GetAll();
            if (TempData.ContainsKey("msgerror"))
            {
                ViewBag.msgerror = TempData["msgerror"].ToString();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(string descPl1, int espec1)
        {
            Plan p = new Plan(descPl1, espec1);
            PlanesLogic plog = new PlanesLogic();
            try
            {
                plog.AddNew(p);
            }
            catch(Exception e)
            {
                TempData.Add("msgerror", "No se pudo registrar el plan >>" + e.Message);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Modificar(int Idpl2, string descPl2, int espec2)
        {
            Plan p = new Plan(Idpl2, descPl2, espec2);
            PlanesLogic plog = new PlanesLogic();
            try
            {
                plog.SaveChanges(p);
            }
            catch(Exception e)
            {
                TempData.Add("msgerror", "No se registraron los cambios >>" + e.Message);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Eliminar(int Idpl3)
        {
            PlanesLogic plog = new PlanesLogic();
            try
            {
                plog.Delete(Idpl3);
            }
            catch(Exception e)
            {
                TempData.Add("msgerror", "No se elimino el plan >>" + e.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
