using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Web.Controllers
{
    public class ComisionesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
