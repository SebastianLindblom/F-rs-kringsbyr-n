using System.Linq;
using System.Collections.Generic;

namespace Business.Ansökningar.Övriga
{
    using ClassLibrary;
    using Business.GeneralRepository;
    public class ÖvrigAnsökningRepository : Repository<AnsökningÖvrig>, IÖvrigAnsökningRepository
    {
        public ÖvrigAnsökningRepository(Data.DataModel context) : base(context)
        {

        }


        public IEnumerable<AnsökningÖvrig> GetWith_Försäkringstagarensefternamn(string efternamn_Företagsnamn)
        {
            return PlutoContext.AnsökningÖvrig.Where(x => x.FörsäkringstagarePerson.efternamn.Contains(efternamn_Företagsnamn) || x.FörsäkringstagareFöretag.Företagsnamn.Contains(efternamn_Företagsnamn));
        }
        public IEnumerable<AnsökningÖvrig> GetWith_Person_Organisations_nummer(string person_Organisations_nummer)
        {
            return PlutoContext.AnsökningÖvrig.Where(x => x.FörsäkringstagarePerson.Personnummer.Contains(person_Organisations_nummer) || x.FörsäkringstagareFöretag.Organisationsnummer.Contains(person_Organisations_nummer));

        }
        public Data.DataModel PlutoContext { get { return Context as Data.DataModel; } }
    }
}
