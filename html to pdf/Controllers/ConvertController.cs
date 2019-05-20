using PdfLibrary;
using PdfLibrary.Options;
using PdfLibrary.ViewAsImage;
using PdfLibrary.ViewAsPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace html_to_pdf.Controllers
{
    public class ConvertController : Controller
    {
        // GET: Convert
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Html()
        {
            return View();
        }
        public ActionResult Link()
        {
            return View();
        }
        public ActionResult Invoice()
        {
            return View();
        }
        public ActionResult Invoice1()
        {
            return View();
        }
        public ActionResult PDFtest()
        {
            return new ViewAsPdf("Invoice1")
            {
                FileName = "Invoice.pdf",
                PageSize = Size.A4,
                PageOrientation = Orientation.Portrait,
                PageMargins = { Left = 0, Right = 0 },
                ContentDisposition = ContentDisposition.Inline
            };
        }

        public ActionResult PNGtest()
        {
            return new ViewAsImage("Invoice1")
            {
                FileName = "Invoice.png", 
                ContentDisposition = ContentDisposition.Inline
            };
        }
        public ActionResult Ticket()
        {
            return View();
        }
    }
}