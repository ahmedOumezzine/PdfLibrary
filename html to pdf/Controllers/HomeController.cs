using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace html_to_pdf.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(String texthtml)
        {
           var fileContent= PdfGenerator.GeneratePdfFromPage(texthtml);
            Stream stream = new MemoryStream(fileContent);
            stream.Flush();
            stream.Position = 0;

            return File(stream, "application/pdf", "Labels.pdf");
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}