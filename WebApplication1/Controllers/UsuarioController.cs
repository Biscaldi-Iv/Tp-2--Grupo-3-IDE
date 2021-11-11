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
            TipoPersonas tp = Models.SessionHepler.GetTipoPersona(HttpContext.Session);
            ViewBag.tipo = tp.Descripcion;
            if (TempData.ContainsKey("msgerror"))
            {
                ViewBag.msgerror = TempData["msgerror"].ToString();
            }
            UsuarioLogic ul = new UsuarioLogic();
            PersonaLogic pl = new PersonaLogic();
            ViewBag.Usuarios = ul.GetAll();
            ViewBag.Personas.pl.GetAll();
            return View();
        }
    }
}
