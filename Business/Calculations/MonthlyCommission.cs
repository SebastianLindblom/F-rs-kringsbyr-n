using System;
using System.Linq;

namespace Business.Calculations
{
    using ClassLibrary;
    public class MonthlyCommission
    {
        private static double semErs { get; set; }
        // Ansökningar
        private static double buSumAck { get; set; }
        private static double vuSumAck { get; set; }
        private static double livSumAck { get; set; }
        private static double övrProv { get; set; }

        // Tillval
        private static double tilsum { get; set; }

        // Provisionen
        private static double provSo { get; set; }
        private static double provLiv { get; set; }

        // beräkningar
        private static double sumAck { get { return buSumAck + vuSumAck; } }
        private static double semErsSum { get { return (provSo + provLiv + övrProv) * semErs; } }
        private static double sumProv { get { return provSo + provLiv + övrProv + semErsSum; } }
        private static double prelSkatt { get; set; }
        private static double skattSum { get { return sumProv * prelSkatt; } }
        private static string insättning { get; set; }
        private static double utbetala { get { return sumProv - skattSum; } }

        public static string[] beräknaProvision(string användarnamn, string år, string månad)
        {
            using (var unitOfWork = new Business.UnitOfWork(new Data.DataModel()))
            {
                Anställd an = unitOfWork.Anställda.Get_Anställd_With_Användarnamn(användarnamn);

                // query fails at date 2200-10-10   year read as 2001 - 180 years from now
                Semesterersättningar se = unitOfWork.Semesterersättningar.Find(x => x.Datum.Contains(år)).FirstOrDefault();
                // deklarera attributen hos den anställde

                if (an.skattesats == null) prelSkatt = 0;
                else prelSkatt = Tool.decimalMaker(an.skattesats);

                if (se != null) if (se.Semesterersättning != null)
                    {
                        semErs = Tool.decimalMaker(se.Semesterersättning);
                    }
                semErs = 0;


                insättning = år + "-" + Convert.ToString(Convert.ToInt32(månad) + 1) + "-" + "25";

                // nollställ summorna
                provSo = 0;
                buSumAck = 0;
                vuSumAck = 0;
                livSumAck = 0;
                provLiv = 0;
                övrProv = 0;

                // räknar alla ansökningar för alla enskilda grundbelopp

                //foreach (AnsökningFöretag2 af in BL.Dreamhome.Controller.Instance.IAnsökningarFöretag().Where(x => x.Anställd.personnummer.Equals(an.personnummer) && (x.Betalningsdatum+"indexable").Substring(0, 6).Contains(string.Concat(år + månad)))) { }
                //foreach (AnsökningÖvrig aö in BL.Dreamhome.Controller.Instance.IAnsökningarÖvrig().Where(x => x.SäljarensPersonnummer.Equals(an.personnummer) && (x.Betalningsdatum+"indexable").Substring(0, 6).Contains(string.Concat(år + månad)))) { if (aö.Premie != null) övrProv += System.Convert.ToDouble(aö.Premie); }


                foreach (AnsökningPrivat a in an.AnsökningPrivat.Where(x => (x.betaldatum + "indexable").Substring(0, 6).Equals(string.Concat(år + månad))))
                {
                    foreach (AnsökningensTillval at in a.AnsökningensTillval)
                    {
                        if (at.Tillval.Typ.ToLower().Contains("liv"))
                            if (at.Tillval.Typ.ToLower().Contains("höj"))
                            {
                                livSumAck += (Tool.decimalMaker(a.Tillvalsbelopp) * Tool.decimalMaker(at.Tillval.TillvalsVariabler.Variabeln));
                            }
                            else
                            {
                                livSumAck += (Tool.decimalMaker(at.Tillval.Belopp) * Tool.decimalMaker(at.Tillval.Belopp));
                            }
                        else if (at.Tillval.Typ.ToLower().Contains("barn")) buSumAck += (Tool.decimalMaker(at.Tillval.Belopp) * Tool.decimalMaker(at.Tillval.TillvalsVariabler.Variabeln));
                        else if (at.Tillval.Typ.ToLower().Contains("vuxen")) vuSumAck += (Tool.decimalMaker(at.Tillval.Belopp) * Tool.decimalMaker(at.Tillval.TillvalsVariabler.Variabeln));
                    }



                    if (a.GrundbeloppAckvärde != null)
                    {
                        if (a.GrundbeloppAckvärde.typavförsäkring.ToLower().Contains("barn")) buSumAck += Tool.decimalMaker(a.GrundbeloppAckvärde.ackvärde);
                        else if (a.GrundbeloppAckvärde.typavförsäkring.ToLower().Contains("vuxen")) vuSumAck += Tool.decimalMaker(a.GrundbeloppAckvärde.ackvärde);


                    }
                    else if (a.Livsförsäkringar != null)
                    {
                        livSumAck += Tool.decimalMaker(a.Livsförsäkringar.Grundbelopp) * Tool.decimalMaker(a.Livsförsäkringar.Variabler.Variabel);
                    }
                }

                double bu_vu_Sum = buSumAck + vuSumAck;

                Provision p = new Provision();
                foreach (Provision c in unitOfWork.Provisioner.GetAll()) if(c.år == år && bu_vu_Sum > System.Convert.ToDouble(c.MinAck_värde) && bu_vu_Sum < System.Convert.ToDouble(c.MaxAck_värde))
                    {
                        p = c;
                    }
                if (p != null) provSo = (buSumAck * Tool.decimalMaker(p.provisionsAndelBarn) + vuSumAck * Tool.decimalMaker(p.provisionsAndelVuxen)) * (1 - (semErs / (semErs + 1)));

                else provSo = 0;


                provLiv = livSumAck * (1 - (semErs / (semErs + 1)));
                övrProv = övrProv * (1 - (semErs / (semErs + 1)));

                string[] ProvisionFörAnställd = new string[18];

                //säljare
                ProvisionFörAnställd[0] = an.Förnamn;
                ProvisionFörAnställd[1] = an.Efternamn;
                ProvisionFörAnställd[2] = an.Gatuadress;
                ProvisionFörAnställd[3] = an.Postadress;

                ProvisionFörAnställd[4] = semErs.ToString();

                // ansökningar
                ProvisionFörAnställd[5] = Convert.ToString(Math.Round(buSumAck + 0.1, 0));
                ProvisionFörAnställd[6] = Convert.ToString(Math.Round(vuSumAck + 0.1));
                ProvisionFörAnställd[7] = Convert.ToString(Math.Round(livSumAck + 0.1));
                ProvisionFörAnställd[8] = Convert.ToString(Math.Round(övrProv + 0.1));

                // provisionen
                ProvisionFörAnställd[9] = Convert.ToString(Math.Round(provSo + 0.1, 0));
                ProvisionFörAnställd[10] = Convert.ToString(Math.Round(provLiv + 0.1, 0));

                //beräkningar       
                ProvisionFörAnställd[11] = Convert.ToString(Math.Round(sumAck + 0.1, 0));
                ProvisionFörAnställd[12] = Convert.ToString(Math.Round(semErsSum + 0.1, 0));
                ProvisionFörAnställd[13] = Convert.ToString(Math.Round(sumProv + 0.1, 0));
                ProvisionFörAnställd[14] = Convert.ToString(prelSkatt);
                ProvisionFörAnställd[15] = Convert.ToString(Math.Round(skattSum + 0.1, 0));
                ProvisionFörAnställd[16] = insättning;
                ProvisionFörAnställd[17] = Convert.ToString(Math.Round((utbetala + 0.1), 0));

                return ProvisionFörAnställd;
            }
        }
    }
}

