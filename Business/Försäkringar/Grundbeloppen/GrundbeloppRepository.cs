namespace Business.Försäkringar.Grundbeloppen
{
    using ClassLibrary;
    using Business.GeneralRepository;
    public class GrundbeloppRepository : Repository<GrundbeloppAckvärde>, IGrundbeloppRepository
    {
        public GrundbeloppRepository(Data.DataModel context) : base(context)
        {

        }
        public Data.DataModel PlutoContext { get { return Context as Data.DataModel; } }
    }
}
