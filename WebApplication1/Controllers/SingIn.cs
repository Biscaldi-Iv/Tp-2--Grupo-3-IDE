using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Web.Controllers
{
    public class SingIn : Controller
    {
        // GET: SingIn
        public ActionResult Index()
        {
            return View();
        }

        // GET: SingIn/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SingIn/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SingIn/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SingIn/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
       
        // POST: SingIn/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SingIn/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SingIn/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
