using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Printing;


namespace Buisness.Integration.Printer
{
    public class Utskrift
    {
        private static int kontroll; // räknare
        private static int räknare; //antal sidor
        private static int index; // rad
        public static void SkrivUtProspekt(List<string> prospekt)
        {
            kontroll = 0;
            index = 0;  
            räknare = prospekt.Count()/10;  // 10 input rader per sida

            PrintDocument dok = new PrintDocument();
            dok.PrintPage += (sender, e) => skrivUtProspekt(e, prospekt);

            dok.Print();
            //FörsäkringstagarnaPrivat fp = new FörsäkringstagarnaPrivat();
            //fp.InaktiveraUtskrivnaProspekt(prospekt);
        }
        private static void indexering()
        {
            index++;
        }
        private static void skrivUtProspekt(PrintPageEventArgs e, List<string> prospekt) //metod för att skriva ut kundprospekt
        {
            if (räknare <= kontroll)
            {
                return;
            }

            if (prospekt[kontroll] != null)
            {
                 //design för utskrift
                e.Graphics.DrawString(string.Format("\t\t\t\tKundprospekt", prospekt[index], prospekt[index]), new Font("Calibir", 14, FontStyle.Regular), Brushes.Black, new Point(30, 100));
                e.Graphics.DrawString(string.Format("Förnamn: {0} \tEfternamn: {1}", prospekt[index], prospekt[index + 1]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 150));
                indexering(); // extra för efternman
                indexering(); e.Graphics.DrawString(string.Format("Personnummer: {0}", prospekt[index]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 170));
                indexering(); e.Graphics.DrawString(string.Format("Gatuadress: {0}", prospekt[index]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 190));
                indexering(); e.Graphics.DrawString(string.Format("Postnummer: {0}", prospekt[index]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 210));
                indexering(); e.Graphics.DrawString(string.Format("Postadress: {0}", prospekt[index]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 230));
                indexering(); e.Graphics.DrawString(string.Format("Telefonnummerhem: {0}", prospekt[index]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 250));
                indexering(); e.Graphics.DrawString(string.Format("Telefonnummerarbete: {0}", prospekt[index]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 270));
                indexering(); e.Graphics.DrawString(string.Format("Email: {0}", prospekt[index]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 290));
                indexering(); e.Graphics.DrawString(string.Format("Agenturnummer: {0}", prospekt[index]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 310));

                e.Graphics.DrawString(string.Format("Utskriftsdatum: {0}", DateTime.Now), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 390));
                 e.Graphics.DrawString(string.Format("Noteringar: "), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 410));
                 e.Graphics.DrawString(string.Format("Kontaktdatum:"), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 430));
                 e.Graphics.DrawString(string.Format("Utfall:"), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 450));
                 e.Graphics.DrawString(string.Format("Säljare:"), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 470));
                 e.Graphics.DrawString(string.Format("Agenturnummer:"), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 490));

                 indexering(); // nästa persons förnamn
            }

            if (räknare > kontroll)
            {
                e.HasMorePages = true;
                kontroll++;
                return;
            }
            else
            {
                e.HasMorePages = false;
                return;
            }
        }

        //PROVISONUTSKRIFT
        private static void SkrivUtProvision(string[] provisionLista) //metod för att skriva ut provision
        {
            kontroll = 0;
            räknare = provisionLista.Count();
            PrintDocument dok = new PrintDocument();
            dok.PrintPage += (sender, e) => skrivUtProvision(e, provisionLista);
            try
            {
                dok.Print();
            }
            catch (Exception e)
            {
               // Controller.Instance.messageboxes.Error(e.Message);
            }


        }

        // ta emot input från interfacet och tilldela till en array som går in i utskrivaren
        public static void ExporteraProvisionTillUtskrift(string Förnamn, string Efternamn, string Gatuadress, string Postadress, string SemesterersättningProv, string BuAckvärde, string VuAckvärde, string LivAckvärde, string ProvÖvrigt, string ProvSo, string ProvLiv, string SummaAckvärde, string SumSemesterers, string SummaProv, string PrelSkattProv, string AvgårSkatt, string InsättningBank, string AttBetala)
        {
            string[] ProvisionFörAnställd = new string[18];
            // Anställd                                                                                                                                                                                                                                                                     
            ProvisionFörAnställd[0] = Förnamn;//fNamn                                                                                                                                                                                                                                       
            ProvisionFörAnställd[1] = Efternamn;//eNamn                                                                                                                                                                                                                                
            ProvisionFörAnställd[2] = Gatuadress;//adress                                                                                                                                                                                                                              
            ProvisionFörAnställd[3] = Postadress;//postAdr

            SemesterersättningProv = ProvisionFörAnställd[4];

            // Ansökningar
            ProvisionFörAnställd[5] = BuAckvärde;//buSumAck 
            ProvisionFörAnställd[6] = VuAckvärde;//vuSumAck 
            ProvisionFörAnställd[7] = LivAckvärde;//livSumAck
            ProvisionFörAnställd[8] = ProvÖvrigt;//övrProv   

            // Provisionen
            ProvisionFörAnställd[9] = ProvSo;//provSo 
            ProvisionFörAnställd[10] = ProvLiv;//provLiv 

            ProvisionFörAnställd[11] = SummaAckvärde;//sumAck    
            ProvisionFörAnställd[12] = SumSemesterers;//semErsSum 
            ProvisionFörAnställd[13] = SummaProv;//sumProv   
            ProvisionFörAnställd[14] = PrelSkattProv;//prelSkatt 
            ProvisionFörAnställd[15] = AvgårSkatt;//skattSum  
            ProvisionFörAnställd[16] = InsättningBank;//insättning
            ProvisionFörAnställd[17] = AttBetala;//utbetala  

            SkrivUtProvision(ProvisionFörAnställd);
        }

        private static void skrivUtProvision(PrintPageEventArgs e, string[] provisionLista) //"design" för utskrift
        {

            e.Graphics.DrawString(string.Format("\t\t\t\tProvisioner", provisionLista[0], provisionLista[1]), new Font("Calibir", 14, FontStyle.Regular), Brushes.Black, new Point(30, 130));
            e.Graphics.DrawString(string.Format("Förnamn:  {0}   Efternamn:  {1}", provisionLista[0], provisionLista[1]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 170));
            e.Graphics.DrawString(string.Format("Gatuadress:  {0}", provisionLista[2]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 190));
            e.Graphics.DrawString(string.Format("Postadress:  {0}", provisionLista[3]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 210));
            e.Graphics.DrawString(string.Format("Semesterersättning prov:  {0}", provisionLista[4]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 230));
            e.Graphics.DrawString(string.Format("BuAckvärde:  {0}", provisionLista[5]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 250));
            e.Graphics.DrawString(string.Format("VuAckvärde:  {0}", provisionLista[6]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 270));
            e.Graphics.DrawString(string.Format("LivAckvärde:  {0}", provisionLista[7]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 290));
            e.Graphics.DrawString(string.Format("ProvÖvrigt:  {0}", provisionLista[8]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 310));
            e.Graphics.DrawString(string.Format("ProvSo:  {0}", provisionLista[9]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 330));
            e.Graphics.DrawString(string.Format("ProvLiv:  {0}", provisionLista[10]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 350));
            e.Graphics.DrawString(string.Format("SummaAckvärde:  {0}", provisionLista[11]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 370));
            e.Graphics.DrawString(string.Format("SumSemesterers:  {0}", provisionLista[12]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 390));
            e.Graphics.DrawString(string.Format("SummaProv:  {0}", provisionLista[13]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 410));
            e.Graphics.DrawString(string.Format("PrelSkattProv:  {0}", provisionLista[14]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 430));
            e.Graphics.DrawString(string.Format("AvgårSkatt:  {0}", provisionLista[15]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 450));
            e.Graphics.DrawString(string.Format("InsättningBank:  {0}", provisionLista[16]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 470));
            e.Graphics.DrawString(string.Format("AttBetala:  {0}", provisionLista[17]), new Font("Calibir", 12, FontStyle.Regular), Brushes.Black, new Point(30, 490));


        }

    }
}
