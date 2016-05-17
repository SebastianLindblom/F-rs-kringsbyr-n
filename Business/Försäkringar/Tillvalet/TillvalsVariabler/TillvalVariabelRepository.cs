namespace Business.Försäkringar.Tillvalet.TillvalsVariabler
{
    using ClassLibrary;
    using Business.GeneralRepository;
    public class TillvalVariabelRepository : Repository<TillvalsVariabler>, ITillvalVariabelRepository
    {
        public TillvalVariabelRepository(Data.DataModel context) : base(context)
        {

        }
        public Data.DataModel PlutoContext { get { return Context as Data.DataModel; } }
    }
}
