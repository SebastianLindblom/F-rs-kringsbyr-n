namespace Business.Personal.Behörigheter
{
    using ClassLibrary;
    using GeneralRepository;
    public interface IBehörighetRepository : IRepository<Behörighet>
    {
        Behörighet Get_Behörighet_With_Roll(string roll);
    }
}
