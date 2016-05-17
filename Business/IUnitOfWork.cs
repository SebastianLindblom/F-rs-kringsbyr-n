using System;
namespace Business
{
    using Business.Ansökningar.Företag;
    using Business.Ansökningar.Privat;
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

    public interface IUnitOfWork : IDisposable
    {

        void Complete();


        IFöretagAnsökningRepository FöretagsAnsökningar { get; }
        IPrivatAnsökningRepository PrivataAnsökningar                   { get; }
        IAnsökningTillvalRepository AnsökningensTillval                 { get; }
        IÖvrigAnsökningRepository ÖvrigaAnsökningar                     { get; }


        IGrundbeloppRepository GrundbeloppAckvärden                     { get; }
        ILivsförsäkringRepository Livsförsäkringar                      { get; }
        ILivsförsäkringVariabelRepository Livsförsäkringsvariabler      { get; }
        ITillvalRepository Tillvalen                                    { get; }
        ITillvalVariabelRepository Tillvalsvariabler                    { get; }

        IFöretagFörsäkringstagareRepository FöretagFörsäkringstagarna   { get; }
        IPrivatFörsäkringstagareRepository PrivatFörsäkringstagarna     { get; }

        IAnställdRepository Anställda                                   { get; }
        IBehörighetRepository Behörigheter                              { get; }
        IProvisionRepository Provisioner                                { get; }
        ISemesterRepository Semesterersättningar                        { get; }
    }
}
