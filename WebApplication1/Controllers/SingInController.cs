using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using Newtonsoft.Json;

namespace UI.Web.Controllers
{
    public class SingInController : Controller
    {
        // GET: SingIn
        public ActionResult Index(string message="")
        {
            
            
            ViewBag.Message = message;
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

        [HttpPost]
        public ActionResult Login(string user, string contra)
        {
            UsuarioLogic ul = new UsuarioLogic();
            PersonaLogic pl = new PersonaLogic();
            TipoPersonaLogic tpl = new TipoPersonaLogic();
            PlanesLogic planl = new PlanesLogic();

            if (ul.VerificarUsuario(user, contra))
            {
                Usuario usuario = ul.RecuperarUsuario(user, contra);
                Persona pers = pl.GetOne(usuario.IdPersona);
                TipoPersonas tp = tpl.GetOne(pers.ID);
                Plan plan = planl.GetOne(pers.IDPlan);
                //HttpContext.Session.SetString("usuario", user);

                //se debe serializar para guardar usando cache distribuida
                var stru= JsonConvert.SerializeObject(usuario);
                HttpContext.Session.SetString("usuario", stru);

                var strTP = JsonConvert.SerializeObject(tp);
                HttpContext.Session.SetString("tipoPers", strTP);

                var strPL = JsonConvert.SerializeObject(plan);
                HttpContext.Session.SetString("plan", strPL);

                // para recuperarlos cuando sea necesario
                //var str = context.Session.GetString(key);
                //var obj = JsonConvert.DeserializeObject<MyType>(str);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return Index("Verifique su nombre de usuario o contraseña");
            } 
        }
    }
}
