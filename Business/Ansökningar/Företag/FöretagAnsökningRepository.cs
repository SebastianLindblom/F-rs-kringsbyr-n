using System.Collections.Generic;
using System.Linq;

namespace Business.Ansökningar.Företag
{

    using ClassLibrary;
    using Business.GeneralRepository;
    public class FöretagAnsökningRepository : Repository<AnsökningFöretag>, IFöretagAnsökningRepository
    {
        public FöretagAnsökningRepository(Data.DataModel context) : base(context)
        {

        }
        public IEnumerable<AnsökningFöretag> GetWith_Företagsnamn(string företagsnamn)
        {
            return PlutoContext.AnsökningFöretag.Where(x => x.FörsäkringstagareFöretag.Företagsnamn.Contains(företagsnamn));
        }
        public IEnumerable<AnsökningFöretag> GetWith_Organisationsnummer(string organisationsnummer)
        {
            return PlutoContext.AnsökningFöretag.Where(x => x.FörsäkringstagareFöretag.Organisationsnummer.Contains(organisationsnummer));
        }

        public Data.DataModel PlutoContext { get { return Context as Data.DataModel; } }
    }
}
