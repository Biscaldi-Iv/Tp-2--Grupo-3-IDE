using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Web.Controllers
{
    public class ReportController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly iPlanService planesService;
        public ReportController(IWebHostEnvironment webHostEnvironment,iPlanService planesService)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.planesService = planesService;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task <IActionResult> Print()
        {
            string mimtype = "";
            int extension = 1;
            var path = $"{this.webHostEnvironment.WebRootPath}\\Reports\\SampleReport2.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
           // parameters.Add("param1", "Welcome to Sarrawy Dev");
            LocalReport localReport = new LocalReport(path);
            var planes = await planesService.GetPlanes();
            localReport.AddDataSource("Planes", planes);
            var result = localReport.Execute(RenderType.Pdf, extension,parameters,mimtype); 
            return File(result.MainStream, "application/Pdf");
        }
    }
}
