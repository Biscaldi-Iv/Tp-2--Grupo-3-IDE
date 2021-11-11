using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace UI.Web.Controllers
{
    [Authorize(Policy = "EstadoReq")]
    public class ReportController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly iPlanService planesService;
        private readonly ICursosService cursoService;
        public ReportController(IWebHostEnvironment webHostEnvironment,iPlanService planesService, ICursosService cursoService)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.planesService = planesService;
            this.cursoService = cursoService;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task <IActionResult> PrintPlanes()
        {
            string mimtype = "";
            int extension = 1;
            var path = $"{this.webHostEnvironment.WebRootPath}\\Reports\\ReportPlanes.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
           // parameters.Add("param1", "Welcome to Sarrawy Dev");
            LocalReport localReport = new LocalReport(path);
            var planes = await planesService.GetPlanes();
            localReport.AddDataSource("Planes", planes);
            var result = localReport.Execute(RenderType.Pdf, extension,parameters,mimtype); 
            return File(result.MainStream, "application/Pdf");
        }
        public async Task<IActionResult> PrintCursos()
        {
            string mimtype = "";
            int extension = 1;
            var path = $"{this.webHostEnvironment.WebRootPath}\\Reports\\ReportCursos.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            // parameters.Add("param1", "Welcome to Sarrawy Dev");
            LocalReport localReport = new LocalReport(path);
            var cursos = await cursoService.GetCursos();
            localReport.AddDataSource("Cursos", cursos);
            var result = localReport.Execute(RenderType.Pdf, extension, parameters, mimtype);
            return File(result.MainStream, "application/Pdf");
        }
    }
}
