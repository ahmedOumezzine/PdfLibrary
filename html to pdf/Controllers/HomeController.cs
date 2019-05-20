using PdfLibrary;
using PdfLibrary.Options;
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
        public ActionResult PDFtest()
        {
            return new ActionAsPdf("Index")
            {
                FileName = "fileName.pdf",
                PageSize = Size.A4,
                PageOrientation = Orientation.Portrait,
                PageMargins = { Left = 0, Right = 0 },
            };
        }

        public ActionResult Pngtest()
        {
            return new ActionAsImage("Index")
            {
                FileName = "fileName.pdf"
            };
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


        public ActionResult HowUse()
        {

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}