using Business.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Web.Filters;

namespace UI.Web.Controllers
{
    [TypeFilter(typeof(authFilter))]
    public class ComisionesController : Controller
    {
        public IActionResult Index()
        {
            TipoPersonas tp = Models.SessionHepler.GetTipoPersona(HttpContext.Session);
            ViewBag.tipo = tp.Descripcion;
            return View();
        }
    }
}
