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
            Models.SessionHepler.IniciarSesion(HttpContext.Session, nombreusuario, contraseña);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult SessionClose()
        {
            HttpContext.Session.Clear();
            
            return RedirectToAction("Index");
        }
    }
}
