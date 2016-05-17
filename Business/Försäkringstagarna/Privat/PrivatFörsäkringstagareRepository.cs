namespace Business.Försäkringstagarna.Privat
{
    using ClassLibrary;
    using Business.GeneralRepository;
    public class PrivatFörsäkringstagareRepository : Repository<FörsäkringstagarePrivat>, IPrivatFörsäkringstagareRepository
    {
        public PrivatFörsäkringstagareRepository(Data.DataModel context) : base(context)
        {

        }
        public Data.DataModel PlutoContext { get { return Context as Data.DataModel; } }
    }
}
