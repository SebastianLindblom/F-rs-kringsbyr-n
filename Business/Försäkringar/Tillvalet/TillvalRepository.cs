namespace Business.Försäkringar.Tillvalet
{
    using ClassLibrary;
    using Business.GeneralRepository;
    public class TillvalRepository : Repository<Tillval>, ITillvalRepository
    {
        public TillvalRepository(Data.DataModel context) : base(context)
        {

        }
        public Data.DataModel PlutoContext { get { return Context as Data.DataModel; } }
    }
}
