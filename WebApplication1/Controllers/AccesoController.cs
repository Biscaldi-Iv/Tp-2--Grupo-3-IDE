using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace UI.Web.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.msgerror = "";
            if (TempData.ContainsKey("msgerror"))
            {
                ViewBag.msgerror = TempData["msgerror"].ToString();
            }
            if (Models.SessionHepler.Sessionstate(HttpContext.Session))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
            
        }

        [HttpPost]
        public ActionResult StartSession(string nombreusuario, string contraseña)
        {
            
            try
            {
                Models.SessionHepler.IniciarSesion(HttpContext.Session, nombreusuario, contraseña);
            }
            catch (Exception ex)
            {
                TempData.Add("msgerror", ex.Message);
            }
           
            return RedirectToAction("Index", "Home");
        }

        public ActionResult SessionClose()
        {
            HttpContext.Session.Clear();
            
            return RedirectToAction("Index");
        }
    }
}
