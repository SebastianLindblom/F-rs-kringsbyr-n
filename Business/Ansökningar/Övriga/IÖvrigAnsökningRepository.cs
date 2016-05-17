namespace Business.Ansökningar.Övriga
{
    using System.Collections.Generic;
    using ClassLibrary;
    using GeneralRepository;
    public interface IÖvrigAnsökningRepository : IRepository<AnsökningÖvrig>
    {
        IEnumerable<AnsökningÖvrig> GetWith_Försäkringstagarensefternamn(string efternamn_Företagsnamn);
        IEnumerable<AnsökningÖvrig> GetWith_Person_Organisations_nummer(string person_Organisations_nummer);
    }
}
