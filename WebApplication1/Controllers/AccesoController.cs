using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using Newtonsoft.Json;

namespace UI.Web.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Load(string nombreusuario, string contraseña)
        {
            UsuarioLogic ul = new UsuarioLogic();
            Usuario usr = ul.RecuperarUsuario(nombreusuario, contraseña);
            var struser = JsonConvert.SerializeObject(usr);
            HttpContext.Session.SetString("usuario", struser);
            return RedirectToAction("Index", "Home");
        }
    }
}
