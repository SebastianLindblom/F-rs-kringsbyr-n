using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Personal.Behörigheter
{
    using ClassLibrary;
    using Business.GeneralRepository;
    public class BehörighetRepository : Repository<Behörighet>, IBehörighetRepository
    {
        public BehörighetRepository(Data.DataModel context) : base(context)
        {

        }

        public Behörighet Get_Behörighet_With_Roll(string roll)
        {
            return PlutoContext.Behörighet.FirstOrDefault(x => x.roll.Equals(roll));
        }

       private Data.DataModel PlutoContext { get { return Context as Data.DataModel; } }
    }
}
