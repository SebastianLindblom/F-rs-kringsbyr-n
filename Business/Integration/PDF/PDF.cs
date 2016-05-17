using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Buisness.Integration.PDF
{
    public class PDF
    {
     
        internal void CreatePdf()
        {
            string År = "2015";
            string Månad = "02";
            string användarnamn = "Rigo";

            string[] array = Business.Calculations.MonthlySales.beräknaMånadsförsäljning(användarnamn, År, Månad);


            Document doc = new Document(iTextSharp.text.PageSize.A4);
            PdfWriter wri1 = PdfWriter.GetInstance(doc, new FileStream(("Provision.pdf"), FileMode.Create));

            PdfPTable TableAnställd = new PdfPTable(3);

            PdfPCell cell = new PdfPCell(new Phrase(" "));
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right

            TableAnställd.AddCell("Vigo"+" "+"Persson");
            TableAnställd.AddCell(" ");
            TableAnställd.AddCell("Provisioner");

            TableAnställd.AddCell("Tallgatan 17");
            TableAnställd.AddCell(" ");
            TableAnställd.AddCell(" "); 

            TableAnställd.AddCell("432 45 Björvik");
            TableAnställd.AddCell(" ");
            TableAnställd.AddCell(" ");

            TableAnställd.AddCell(" ");
            TableAnställd.AddCell(" ");
            TableAnställd.AddCell(" ");

            TableAnställd.AddCell("Period ");
            TableAnställd.AddCell("Jan ");
            TableAnställd.AddCell("2015");


            TableAnställd.AddCell(cell);

            PdfPTable TableProvision = new PdfPTable(4);
            TableProvision.AddCell("Bu sum");
            TableProvision.AddCell("170 800");
            TableProvision.AddCell(" ");
            TableProvision.AddCell(" ");

            TableProvision.AddCell("Vu sum");
            TableProvision.AddCell("670 350");
            TableProvision.AddCell(" ");
            TableProvision.AddCell(" ");

            TableProvision.AddCell("Summa ackvärde");
            TableProvision.AddCell("841 150");
            TableProvision.AddCell("Prov so");
            TableProvision.AddCell("13 213");

            TableProvision.AddCell("Liv sum");
            TableProvision.AddCell("700 000");
            TableProvision.AddCell("prov liv");
            TableProvision.AddCell("3125");

            TableProvision.AddCell("Övrigt provision");
            TableProvision.AddCell(" ");
            TableProvision.AddCell("Prov övrigt");
            TableProvision.AddCell("567");

            doc.Open();
            
            doc.Add(TableAnställd);

            doc.Add(TableProvision);

            doc.Close();

            //uSystem.Diagnostics.Process.Start("C:\\Users\\Sebastian\\Desktop\\VisualStudiotfs\\SU\\IF\\bin\\Debug\\Provision.pdf");

        }
    }
}
