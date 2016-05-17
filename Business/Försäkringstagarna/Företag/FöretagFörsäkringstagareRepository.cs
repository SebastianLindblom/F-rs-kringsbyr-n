using System.Collections.Generic;
using System.Linq;
namespace Business.Försäkringstagarna.Företag
{
    using ClassLibrary;
    using Business.GeneralRepository;
    public class FöretagFörsäkringstagareRepository : Repository<FörsäkringstagareFöretag>, IFöretagFörsäkringstagareRepository
    {
        public FöretagFörsäkringstagareRepository(Data.DataModel context) : base(context)
        {

        }
     

        public Data.DataModel PlutoContext { get { return Context as Data.DataModel; } }
    }
}
