
using System.Collections.Generic;

namespace Business.Personal.Anställde
{
    using ClassLibrary;
    using GeneralRepository;
    public interface IAnställdRepository: IRepository<Anställd>
    {
        IEnumerable<Anställd> GetByLastname(string efternam);
        Anställd Get_Anställd_With_Agenturnummer(string agenturnummer);
        Anställd Get_Anställd_With_Användarnamn(string användarnamn);
        Anställd Get_Anställd_With_Personnummer(string personnummer);
    }
}