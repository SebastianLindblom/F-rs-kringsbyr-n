namespace Business.Ansökningar.Privat
{
    using System.Collections.Generic;
    using ClassLibrary;
    using GeneralRepository;
    public interface IPrivatAnsökningRepository : IRepository<AnsökningPrivat>
    {
        IEnumerable<AnsökningPrivat> GetWith_FörsäkringstagarensEfternamn(string efternamn);
        IEnumerable<AnsökningPrivat> GetWith_FörsäkringstagarensPersonnummer(string personnummer);

        IEnumerable<AnsökningPrivat> GetWith_FörsäkradesEfternamn(string efternamn);
        IEnumerable<AnsökningPrivat> GetWith_FörsäkradesFörnamn(string förnamn);
        IEnumerable<AnsökningPrivat> GetWith_FörsäkradesPersonnummer(string personnummer);
    }
}
