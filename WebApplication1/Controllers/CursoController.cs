﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Web.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
