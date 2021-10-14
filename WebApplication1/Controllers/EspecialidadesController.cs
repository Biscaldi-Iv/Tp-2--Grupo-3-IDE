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
            //chequear session o agregar chequeo a config(ver) para que envie a acceso
            return View();
        }

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

    }
}
