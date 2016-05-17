namespace Business.Ansökningar.Företag
{
    using System.Collections.Generic;
    using ClassLibrary;
    using GeneralRepository;
    public interface IFöretagAnsökningRepository : IRepository<AnsökningFöretag>
    {
        IEnumerable<AnsökningFöretag> GetWith_Företagsnamn(string företagsnamn);
        IEnumerable<AnsökningFöretag> GetWith_Organisationsnummer(string organisationsnummer);
    }
}
