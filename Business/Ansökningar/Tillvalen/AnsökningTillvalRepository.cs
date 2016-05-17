using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Ansökningar.Tillvalen
{
    using ClassLibrary;
    using Business.GeneralRepository;
    public class AnsökningTillvalRepository : Repository<AnsökningensTillval>, IAnsökningTillvalRepository
    {
        public AnsökningTillvalRepository(Data.DataModel context) : base(context)
        {

        }
        public Data.DataModel PlutoContext { get { return Context as Data.DataModel; } }
    }
}
