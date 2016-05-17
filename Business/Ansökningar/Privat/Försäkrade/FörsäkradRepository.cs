namespace Business.Ansökningar.Privat.Försäkrade
{
    using ClassLibrary;
    using GeneralRepository;
    public class FörsäkradRepository : Repository<Försäkrad> , IFörsäkradRepository
    {
        public FörsäkradRepository(Data.DataModel context) : base(context)
        {

        }
    }
}
