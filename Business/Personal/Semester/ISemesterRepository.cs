using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Personal.Semester
{
    using ClassLibrary;
    using GeneralRepository;
    public interface ISemesterRepository : IRepository<Semesterersättningar>
    {
        Semesterersättningar Get_Semesterersättning_From_Ersättning(string ersättning);
    }
}
