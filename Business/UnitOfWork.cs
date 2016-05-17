using Data;
using System.Data.Entity.Validation;

namespace Business
{
    using Business.Ansökningar.Företag;
    using Business.Ansökningar.Privat;
    using Business.Ansökningar.Privat.Försäkrade;
    using Business.Ansökningar.Tillvalen;
    using Business.Ansökningar.Övriga;

    using Business.Försäkringar.Grundbeloppen;
    using Business.Försäkringar.Livsförsäkringar;
    using Business.Försäkringar.Livsförsäkringar.Variabler;
    using Business.Försäkringar.Tillvalet;
    using Business.Försäkringar.Tillvalet.TillvalsVariabler;

    using Business.Försäkringstagarna.Företag;
    using Business.Försäkringstagarna.Privat;

    using Business.Personal.Anställde;
    using Business.Personal.Behörigheter;
    using Business.Personal.Provisioner;
    using Business.Personal.Semester;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataModel _context;

        public UnitOfWork(DataModel context)
        {
            _context = context;

            FöretagsAnsökningar = new FöretagAnsökningRepository(_context);
            PrivataAnsökningar = new PrivatAnsökningRepository(_context);
            Försäkrade = new FörsäkradRepository(_context);
            AnsökningensTillval = new AnsökningTillvalRepository(_context);
            ÖvrigaAnsökningar = new ÖvrigAnsökningRepository(_context);

            GrundbeloppAckvärden = new GrundbeloppRepository(_context);
            Livsförsäkringar = new LivsförsäkringRepository(_context);
            Livsförsäkringsvariabler = new LivsförsäkringVariabelRepository(_context);
            Tillvalen = new TillvalRepository(_context);
            Tillvalsvariabler = new TillvalVariabelRepository(_context);

            FöretagFörsäkringstagarna = new FöretagFörsäkringstagareRepository(_context);
            PrivatFörsäkringstagarna = new PrivatFörsäkringstagareRepository(_context);

            Anställda = new AnställdRepository(_context);
            Behörigheter = new BehörighetRepository(_context);
            Provisioner = new ProvisionRepository(_context);
            Semesterersättningar = new SemesterRepository(_context);
        }

        public IFöretagAnsökningRepository FöretagsAnsökningar { get; private set; }
        public IPrivatAnsökningRepository PrivataAnsökningar { get; private set; }
        public IFörsäkradRepository Försäkrade { get; private set; }
        public IAnsökningTillvalRepository AnsökningensTillval { get; private set; }
        public IÖvrigAnsökningRepository ÖvrigaAnsökningar { get; private set; }

        public IGrundbeloppRepository GrundbeloppAckvärden { get; private set; }
        public ILivsförsäkringRepository Livsförsäkringar { get; private set; }
        public ILivsförsäkringVariabelRepository Livsförsäkringsvariabler { get; private set; }
        public ITillvalRepository Tillvalen { get; private set; }
        public ITillvalVariabelRepository Tillvalsvariabler { get; private set; }

        public IFöretagFörsäkringstagareRepository FöretagFörsäkringstagarna { get; private set; }
        public IPrivatFörsäkringstagareRepository PrivatFörsäkringstagarna { get; private set; }

        public IAnställdRepository Anställda { get; private set; }
        public IBehörighetRepository Behörigheter { get; private set; }
        public IProvisionRepository Provisioner { get; private set; }
        public ISemesterRepository Semesterersättningar { get; private set; }


        public void Complete()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine(("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage));
                    }
                }
            }
        }

        public void Dispose()
        {
            Complete();
            _context.Dispose();
        }
    }
}
