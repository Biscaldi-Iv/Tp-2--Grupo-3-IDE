using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using Microsoft.AspNetCore.Authorization;

namespace UI.Web.Controllers
{
    [Authorize(Policy = "EstadoReq")]
    public class CursoController : Controller
    {
        public IActionResult Index()
        {
            CursosLogic clog = new CursosLogic();
            ComisionLogic comlog = new ComisionLogic();
            MateriasLogic matlog = new MateriasLogic();
            var cursos = from cur in clog.getAll()
                         join coms in comlog.GetAll() on cur.IDComision equals coms.ID
                         join mats in matlog.GetAll() on cur.IDMateria equals mats.ID
                         select (cur.ID, cur.Descripcion, coms.Descripcion, mats.Descripcion, cur.AnioCalendario, cur.Cupo);
            ViewBag.cursos = cursos;
            ViewBag.comisiones = comlog.GetAll();
            ViewBag.materias = matlog.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(int comision1, int materia1, int añocal1, int cupo1)
        {
            try
            {
                Curso c = new Curso(0, materia1, comision1, añocal1, cupo1, "");
                CursosLogic clog = new CursosLogic();
                clog.AddNew(c);
            }
            catch(Exception ex)
            {
                TempData.Remove("msgerror");
                TempData.Add("msgerror", "No se registro el curso >>" + ex.Message);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Modificar(int IdCurso2, int comision2, int materia2, int añocal2, int cupo2)
        {
            try
            {
                Curso c = new Curso(IdCurso2, materia2, comision2, añocal2, cupo2, "");
                CursosLogic clog = new CursosLogic();
                clog.Save(c);
            }
            catch (Exception ex)
            {
                TempData.Remove("msgerror");
                TempData.Add("msgerror", "No se guardaron los cambios >>" + ex.Message);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Eliminar(int IdCurso3)
        {
            CursosLogic clog = new CursosLogic();
            try
            {
                clog.Delete(IdCurso3);
            }
            catch (Exception ex)
            {
                TempData.Remove("msgerror");
                TempData.Add("msgerror", "No se elimino el curso >>" + ex.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
