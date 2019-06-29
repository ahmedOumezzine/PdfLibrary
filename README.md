
# How to easily create a PDF document in ASP NET MVC
PdfLibrary is an extremely simple way to convert an HTML response directly into a PDF document and print the PDF document into an ASP.NET MVC.
[![N|Solid](https://i.ytimg.com/vi/_EqYMNdbrsc/hqdefault.jpg)](https://github.com/ahmedOumezzine/PdfLibrary)

We will show how to use the PdfLibrary library to easily generate PDF documents while working on the .NET MVC Web project.

PdfLibrary is based on the wkhtmltopdf tool to create a PDF file from HTML content displayed in a browser. It uses the web kit engine used by Chrome to display the HTML code. And support most tags and HTML styles.

[![N|Solid](https://1.bp.blogspot.com/-g_epINxXjAw/XPWUA89HAWI/AAAAAAAAB6M/Xa2BrinE470bdmIKBi-6dGm3MtI6_HaswCLcBGAs/s320/image001.jpg)](https://github.com/ahmedOumezzine/PdfLibrary)

# Configure this library on your project
Let's now create an example for how to easily create a PDF document in ASP.NET.NET MVC

`Step 1 :`
Let's start from the beginning by creating a new ASP.NET MVC project called MVC_PDFGenerator
`Step 2 :`
Let's start by installing the PdfLibrary library:
```
Install-Package PdfLibrary
```
Or search for PdfLibrary in the Nuget package window

## how it works?
for View a PDF document in a browser
`Step 1 :`
After adding the controller, we will now add an action to this controller and prepared you view page 
`step 2:`
The solution is implemented with four classes of PdfLibrary in RapportPDFController.cs to generate a PDF / Image file.

**ViewAsPdf** - This class will generate the PDF based on the views.
```
          public ActionResult DownloadViewPDF ()
         {
             return new PdfLibrary.ViewAsPdf ("DemoAsPDF");
         }
```

**ActionAsPdf** - will use another method of action to generate a PDF file using the view
```
    public ActionResult DownloadActionAsPDF ()
         {
             return new PdfLibrary.ActionAsPdf ("DemoAsPDF") {FileName = "TestViewAsPdf.pdf"};
         }
```


**ViewAsImage** - This class will generate the Image based on the views.
```
       public ActionResult DownloadViewImage ()
         {
             return new PdfLibrary.ViewAsImage ("DemoAsPDF");
         }
```




**ActionAsImage** : will use another action method to generate an image file using the view
```
         public ActionResult DownloadActionAsImage ()
         {
             return new PdfLibrary.ActionAsImage ("DemoAsPDF") {FileName = "TestViewAsImage.png"};
             }
 ```
 
 ## demo 
 you can download the source code in Github https://github.com/ahmedOumezzine/MVC_PDFGenerator
