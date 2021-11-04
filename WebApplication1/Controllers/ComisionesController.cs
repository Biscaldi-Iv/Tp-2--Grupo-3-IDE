using Business.Entities;
using Business.Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Web.Controllers
{
    [Authorize(Policy = "EstadoReq")]
    public class ComisionesController : Controller
    {
        public IActionResult Index()
        {
            TipoPersonas tp = Models.SessionHepler.GetTipoPersona(HttpContext.Session);
            ViewBag.tipo = tp.Descripcion;
            ComisionLogic cl = new ComisionLogic();
            PlanesLogic pl = new PlanesLogic();
            List<Plan> planes = pl.GetAll();
            List<Comision> comisiones = cl.GetAll();
            var coms = from comis in comisiones
                       join pls in planes on comis.IDPlan equals pls.ID
                       select
            (comis.ID, comis.Descripcion, pls.Descripcion, comis.AnioEspecialidad, pls.ID);
            ViewBag.comisiones = coms;
            ViewBag.planes = planes;
            if (TempData.ContainsKey("msgerror"))
            {
                ViewBag.msgerror = TempData["msgerror"].ToString();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(string descCom1, int plan1, int anio1)
        {
            ComisionLogic cl = new ComisionLogic();
            Comision c = new Comision(0, anio1, plan1, descCom1);
            try
            {
                cl.AddNew(c);
            }
            catch (Exception ex)
            {
                TempData.Add("msgerror", "No se registaro la comision >> " + ex.Message);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult GuardarCambio(int idCom2,string descCom2, int plan2, int anio2)
        {
            //solucionar error de edicion porque no se selecciona plan
            ComisionLogic cl = new ComisionLogic();
            Comision c = new Comision(idCom2, anio2, plan2, descCom2);
            try
            {
                cl.SaveChanges(c);
            }
            catch (Exception ex)
            {
                TempData.Add("msgerror", "No se registararon los cambios >> "+ex.Message);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Eliminar(int idCom3)
        {
            ComisionLogic cl = new ComisionLogic();
            try
            {
                cl.Delete(idCom3);
            }
            catch (Exception ex)
            {
                TempData.Add("msgerror", "No fue posible eliminar la comision >> " + ex.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
