namespace Business.Försäkringar.Livsförsäkringar.Variabler
{
    using ClassLibrary;
    using Business.GeneralRepository;
    public class LivsförsäkringVariabelRepository : Repository<Variabler>, ILivsförsäkringVariabelRepository
    {
        public LivsförsäkringVariabelRepository(Data.DataModel context) : base(context)
        {

        }
        public Data.DataModel PlutoContext { get { return Context as Data.DataModel; } }
    }
}
