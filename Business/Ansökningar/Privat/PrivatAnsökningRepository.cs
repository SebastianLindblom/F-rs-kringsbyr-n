using System.Collections.Generic;
using System.Linq;

namespace Business.Ansökningar.Privat
{
    using ClassLibrary;
    using Business.GeneralRepository;
    public class PrivatAnsökningRepository : Repository<AnsökningPrivat>, IPrivatAnsökningRepository
    {
        public PrivatAnsökningRepository(Data.DataModel context) : base(context)
        {

        }
        public IEnumerable<AnsökningPrivat> GetWith_FörsäkringstagarensEfternamn(string efternamn)
        {
            return PlutoContext.AnsökningPerson.Where(x => x.FörsäkringstagarePerson.efternamn.Contains(efternamn));
        }
        public IEnumerable<AnsökningPrivat> GetWith_FörsäkringstagarensPersonnummer(string personnummer)
        {
            return PlutoContext.AnsökningPerson.Where(x => x.FörsäkringstagarePerson.Personnummer.Contains(personnummer));
        }

        public IEnumerable<AnsökningPrivat> GetWith_FörsäkradesEfternamn(string efternamn)
        {
            //eager loading
            return PlutoContext.AnsökningPerson.Include("GrundbeloppAckvärde").Where(x => x.Försäkrad.All(y=> y.FörsäkringstagarePerson.efternamn.Contains(efternamn)));
        }
        public IEnumerable<AnsökningPrivat> GetWith_FörsäkradesFörnamn(string förnamn)
        {
            return PlutoContext.AnsökningPerson.Where(x => x.Försäkrad.All(y => y.FörsäkringstagarePerson.förnamn.Contains(förnamn)));
        }
        public IEnumerable<AnsökningPrivat> GetWith_FörsäkradesPersonnummer(string personnummer)
        {
            return PlutoContext.AnsökningPerson.Where(x => x.Försäkrad.All(y => y.FörsäkringstagarePerson.Personnummer.Contains(personnummer)));
        }
        public Data.DataModel PlutoContext { get { return Context as Data.DataModel; } }
    }
}
