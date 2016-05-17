namespace Business.Försäkringar.Livsförsäkringar
{
    using ClassLibrary;
    using Business.GeneralRepository;
    public class LivsförsäkringRepository : Repository<Livsförsäkringar>, ILivsförsäkringRepository
    {
        public LivsförsäkringRepository(Data.DataModel context) : base(context)
        {

        }
        public Data.DataModel PlutoContext { get { return Context as Data.DataModel; } }
    }
}
