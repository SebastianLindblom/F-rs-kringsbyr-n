using System.Collections.Generic;
using System.Linq;

namespace Business.Personal.Anställde
{
    using ClassLibrary;
    using GeneralRepository;
    public class AnställdRepository : Repository<Anställd> , IAnställdRepository
    {
        public AnställdRepository(Data.DataModel context) : base(context)
        {

        }

        public IEnumerable<Anställd> GetByLastname(string efternam)
        {
            return PlutoContext.Anställd.Where(x => x.Efternamn.Equals(efternam));
        }

        public Anställd Get_Anställd_With_Användarnamn(string användarnamn)
        {
            return PlutoContext.Anställd.Where(x => x.Användarnamn.Equals(användarnamn)).FirstOrDefault();
        }
        public Anställd Get_Anställd_With_Agenturnummer(string agenturnummer)
        {
            return PlutoContext.Anställd.Where(x => x.Agenturnummer.Equals(agenturnummer)).FirstOrDefault();
        }
        public Anställd Get_Anställd_With_Personnummer(string personnummer)
        {
            return PlutoContext.Anställd.Where(x => x.Personnummer.Equals(personnummer)).FirstOrDefault();

        }

        public Data.DataModel PlutoContext { get { return Context as Data.DataModel; } }
    }
}
