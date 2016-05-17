using System.Collections.Generic;

namespace Business.Calculations
{
    using ClassLibrary;
    using System;
    public class YearlyReport
    {
        public static List<List<string>> YearStatistics(string År)
        {

            List<List<string>> AnställdaResultat = new List<List<string>>();

            
            int antalFörsäkringar;

            using (var unitOfWork = new Business.UnitOfWork(new Data.DataModel()))
            {
                var List_Of_Användare = unitOfWork.Anställda.GetAll();



                foreach (Anställd anställd in List_Of_Användare)
                {
                    
                    antalFörsäkringar = 0;

                    List<string> MånadResultat = new List<string>();
                    MånadResultat.Add(string.Concat(anställd.Förnamn + " " + anställd.Efternamn));
                    string Månad; // Temp för konvertering av String.Concat

                    // räknar alla ansökningar för alla enskilda grundbelopp
                    for (int månad = 1; månad < 13; månad++)
                    {
                        if (månad < 10) Månad = string.Concat("0" + månad);
                        else Månad = Convert.ToString(månad);

                        double buSumAck = 0;
                        double vuSumAck = 0;



                        var List_Of_AnsökningPrivat_From_Användare = unitOfWork.PrivataAnsökningar.GetAll();

                        //foreach (AnsökningPrivat a in List_Of_AnsökningPrivat_From_Användare.Where(x => x.Säljare.Equals(anställd.agenturnummer) && (x.Betalningsdatum + "indexable").Substring(0, 6).Equals(string.Concat(År + Månad))).ToList())
                        foreach (AnsökningPrivat a in anställd.AnsökningPrivat)
                        {

                            string försäkringstyp = "";
                            if (a.GrundbeloppAckvärde != null) försäkringstyp = a.GrundbeloppAckvärde.typavförsäkring;
                            if (a.Livsförsäkringar != null) försäkringstyp = a.Livsförsäkringar.Typ;


                            if ((a.betaldatum + "indexable").Substring(0, 6).Equals(string.Concat(År + Månad)))
                            {
                                foreach (AnsökningensTillval at in a.AnsökningensTillval)
                                {
                                    // Om det inte finns någon försäkringstyp men om det finns tillval räknas de inte in (är detta ett problem för kunden?)
                                    if (försäkringstyp.ToLower().Contains("barn")) buSumAck += Tool.decimalMaker(at.Tillval.Belopp) * Tool.decimalMaker(at.Tillval.TillvalsVariabler.Variabeln);
                                    else if (försäkringstyp.ToLower().Contains("vuxen")) vuSumAck += Tool.decimalMaker(at.Tillval.Belopp) * Tool.decimalMaker(at.Tillval.TillvalsVariabler.Variabeln);
                                }
                            } // för varje tillval i ansökningen med ett agenturnummer

                            if (a.GrundbeloppAckvärde != null) // för varje grundbelopp i ansökningen
                            {


                                if (a.GrundbeloppAckvärde.typavförsäkring.ToLower().Contains("barn")) buSumAck += Tool.decimalMaker(a.GrundbeloppAckvärde.ackvärde);
                                else if (a.GrundbeloppAckvärde.typavförsäkring.ToLower().Contains("vuxen")) vuSumAck += Tool.decimalMaker(a.GrundbeloppAckvärde.ackvärde);


                            }
                            else if (a.Livsförsäkringar != null)
                            {

                                if (a.Livsförsäkringar.Typ.ToLower().Contains("barn")) buSumAck += Tool.decimalMaker(a.Livsförsäkringar.Grundbelopp) * Tool.decimalMaker(a.Livsförsäkringar.Variabler.Variabel);
                                else if (a.Livsförsäkringar.Typ.ToLower().Contains("vuxen")) vuSumAck += Tool.decimalMaker(a.Livsförsäkringar.Grundbelopp) * Tool.decimalMaker(a.Livsförsäkringar.Variabler.Variabel);


                            }

                        }



                        // if (buSumAck + vuSumAck > 0) försäkring = true; // om det finns en barnförsäkring men inte en vuxenförsäkring

                        MånadResultat.Add(Convert.ToString(buSumAck)); // barnförsäkringar
                        MånadResultat.Add(Convert.ToString(vuSumAck)); // vuxenförsäkringar
                        MånadResultat.Add(Convert.ToString(buSumAck + vuSumAck)); // summa försäkringar

                    } // Month

                    AnställdaResultat.Add(MånadResultat); // om det finns en försäkring läggs årsresultatet till med den anställde
                } // Year - Employee
            }
            return AnställdaResultat;
        } // method
    }
}
