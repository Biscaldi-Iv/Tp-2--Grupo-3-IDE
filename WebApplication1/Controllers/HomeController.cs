using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Business.Entities;
using Newtonsoft.Json;

namespace UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (Models.SessionHepler.Sessionstate(HttpContext.Session))
            {
                try
                {
                    Usuario u = Models.SessionHepler.GetUsuario(HttpContext.Session);
                    ViewBag.usuario = u.NombreUsuario;

                    TipoPersonas tp = Models.SessionHepler.GetTipoPersona(HttpContext.Session);
                    ViewBag.tipo = tp.Descripcion;

                }
                catch (Exception)
                {
                    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
                }

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Acceso");
            }
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
