namespace Business.Personal.Provisioner
{
    using ClassLibrary;
    using Business.GeneralRepository;
    using System.Linq;
    public class ProvisionRepository : Repository<Provision>, IProvisionRepository
    {

        public ProvisionRepository(Data.DataModel context) : base(context)
        {

        }
        public Provision Get_Provision_With_Year_Sum(string year, string sum)
        {
            return PlutoContext.Provision.SingleOrDefault(x => x.år == year && Tool.decimalMaker(sum) > Tool.decimalMaker(x.MinAck_värde) && Tool.decimalMaker(sum) < Tool.decimalMaker(x.MaxAck_värde));
        }
        public Data.DataModel PlutoContext { get { return Context as Data.DataModel; } }
    }
}
