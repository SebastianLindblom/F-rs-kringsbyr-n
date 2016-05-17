using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Personal.Semester
{
    using ClassLibrary;
    using Business.GeneralRepository;
    public class SemesterRepository : Repository<Semesterersättningar>, ISemesterRepository
    {
       
        public SemesterRepository(Data.DataModel context) : base(context)
        {

        }
        public Semesterersättningar Get_Semesterersättning_From_Ersättning(string ersättning)
        {
            return PlutoContext.Semesterersättningar.FirstOrDefault(x => x.Semesterersättning.Equals(ersättning));
        }
        private Data.DataModel PlutoContext { get { return Context as Data.DataModel; } }
    }
}
