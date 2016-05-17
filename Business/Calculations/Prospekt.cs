using System.Collections.Generic;

namespace Business.Calculations
{
    using ClassLibrary;
    using System.Linq;
    public class Prospekt
    {


        public static List<string> Prospekter()
        {

            List<string> prospekter = new List<string>();

            using (var unitOfWork = new UnitOfWork(new Data.DataModel()))
            {
                IEnumerable<FörsäkringstagarePrivat> prospektBarn = unitOfWork.PrivataAnsökningar.Find(x => x.GrundbeloppAckvärde.typavförsäkring.ToLower().Contains("barn")).Select(x => x.FörsäkringstagarePerson);
                IEnumerable<FörsäkringstagarePrivat> prospektVuxen = unitOfWork.PrivataAnsökningar.Find(x => x.GrundbeloppAckvärde.typavförsäkring.ToLower().Contains("barn")).Select(x => x.FörsäkringstagarePerson);
                foreach (FörsäkringstagarePrivat fp in prospektBarn) if (!prospektVuxen.Contains(fp))
                    {
                        prospekter.Add(fp.förnamn); //1
                        prospekter.Add(fp.efternamn);
                        prospekter.Add(fp.Personnummer);
                        prospekter.Add(fp.gatuadress);
                        prospekter.Add(fp.postnummer); // 5
                        prospekter.Add(fp.postadress);
                        prospekter.Add(fp.telefonnummerhem);
                        prospekter.Add(fp.telefonnummerarb);
                        prospekter.Add(fp.mail);
                        prospekter.Add("agenturnummer"); // 10
                        // om det inte fanns en vuxenförsäkring ska kunden läggas in i prospekten och kontaktas (ska kunden kunna kontaktas flera ggr?)
                    }

            }
            return prospekter;
        }
    }
}
