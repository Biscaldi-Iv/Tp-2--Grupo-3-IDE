using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Web.Controllers
{
    public class EspecialidadesController : Controller
    {
        public IActionResult Index()
        {
            //chequear session o agregar chequeo a config(ver) para que envie a acceso
            return View();
        }
    }
}
