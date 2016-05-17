using System;
using System.Linq;

namespace Business.Calculations
{
    using ClassLibrary;
    public class MonthlySales
    {
        public static string[] beräknaMånadsförsäljning(string användarnamn, string år, string månad)
        {
            double buSumAck = 0;
            double vuSumAck = 0;
            double livSumAck = 0;
            double övrProv = 0;
            double förSumAck = 0;

            using (var unitOfWork = new Business.UnitOfWork(new Data.DataModel()))
            {
                Anställd an = unitOfWork.Anställda.Get_Anställd_With_Användarnamn(användarnamn);

                int AntalSOB = 0;
                int AntalSOV = 0;
                int AntalLIV = 0;
                int AntalÖVR = 0;
                int AntalFÖR = 0;

                foreach (AnsökningFöretag af in an.AnsökningFöretag.Where(x => (x.Betalddatum + "indexabletext").Substring(0, 6).Contains(string.Concat(år + månad))))
                {
                    förSumAck = +Tool.decimalMaker(af.Premie);
                    AntalFÖR++;
                }
                foreach (AnsökningÖvrig aö in an.AnsökningÖvrig.Where(x => (x.Betaldatum + "indexabletext").Substring(0, 6).Contains(string.Concat(år + månad))))
                {
                    övrProv = +Tool.decimalMaker(aö.Premie);
                    AntalÖVR++;
                }
                foreach (AnsökningPrivat ap in an.AnsökningPrivat.Where(x => (x.betaldatum + "indexabletext").Substring(0, 6).Contains(string.Concat(år + månad))))
                {


                    foreach (AnsökningensTillval at in ap.AnsökningensTillval)
                    {
                        if (at.Tillval.Typ.ToLower().Contains("liv"))
                            if (at.Tillval.Typ.ToLower().Contains("höj"))
                            {
                                livSumAck += (Tool.decimalMaker(ap.Tillvalsbelopp) * Tool.decimalMaker(at.Tillval.TillvalsVariabler.Variabeln));
                            }
                            else
                            {
                                livSumAck += (Tool.decimalMaker(at.Tillval.Belopp) * Tool.decimalMaker(at.Tillval.Belopp));
                            }
                        else if (at.Tillval.Typ.ToLower().Contains("barn")) buSumAck += (Tool.decimalMaker(at.Tillval.Belopp) * Tool.decimalMaker(at.Tillval.TillvalsVariabler.Variabeln));
                        else if (at.Tillval.Typ.ToLower().Contains("vuxen")) vuSumAck += (Tool.decimalMaker(at.Tillval.Belopp) * Tool.decimalMaker(at.Tillval.TillvalsVariabler.Variabeln));
                    }
                    if (ap.GrundbeloppAckvärde != null)
                    {
                        if (ap.GrundbeloppAckvärde.typavförsäkring.ToLower().Contains("barn")) { buSumAck += Tool.decimalMaker(ap.GrundbeloppAckvärde.ackvärde); AntalSOB++; }
                        else if (ap.GrundbeloppAckvärde.typavförsäkring.ToLower().Contains("vuxen")) { vuSumAck += Tool.decimalMaker(ap.GrundbeloppAckvärde.ackvärde); AntalSOV++; }


                    }
                    else if (ap.Livsförsäkringar != null)
                    {
                        livSumAck += Convert.ToDouble(ap.Livsförsäkringar.Grundbelopp) * Tool.decimalMaker(ap.Livsförsäkringar.Variabler.Variabel);
                    }
                }





                string[] statistik = new string[10];
                statistik[0] = Convert.ToString(AntalSOB);
                statistik[1] = Convert.ToString(AntalSOV);
                statistik[2] = Convert.ToString(AntalLIV);
                statistik[3] = Convert.ToString(AntalÖVR);
                statistik[4] = Convert.ToString(AntalFÖR);

                statistik[5] = Convert.ToString(buSumAck);
                statistik[6] = Convert.ToString(vuSumAck);
                statistik[7] = Convert.ToString(livSumAck);
                statistik[8] = Convert.ToString(övrProv);
                statistik[9] = Convert.ToString(förSumAck);

                return statistik;
            }
        }
    }
}

