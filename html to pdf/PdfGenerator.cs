using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace html_to_pdf
{
    public class PdfGenerator
    {
        public static Byte[] GeneratePdfFromFragment(string htmlFragment)
        {
            var html = string.Format(@"
            <html xmlns='http://www.w3.org/1999/xhtml' xml:lang='en'>
            <head>
            <style type='text/css'>
            table,td {{border: 1px solid black;}}

            div {{ white-space: nowrap; padding: 2px;}}
            table{{ border-collapse: collapse; width: 100%; empty-cells: show;}}
            body table {{font-size: 50%;}}
            th {{width:500px; height: 28px;}}
            td {{width:300px; height: 28px;}}
            </style>
            </head><body>{0}</body></html>", htmlFragment);

            return generate(html);
        }

        public static Byte[] GeneratePdfFromPage(string htmlPage)
        {
            return generate(htmlPage);
        }

        private static Byte[] generate(string html)
        {
            using (var memoryStream = new MemoryStream())
            {
                var pdfDocument = new Document(PageSize.LETTER);
                var pdfWriter = PdfWriter.GetInstance(pdfDocument, memoryStream);
                pdfDocument.Open();
                using (var fw = new StringReader(html))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(pdfWriter, pdfDocument, fw);
                    pdfDocument.Close();
                    fw.Close();
                }
                return memoryStream.ToArray();
            }
        }
    }
}