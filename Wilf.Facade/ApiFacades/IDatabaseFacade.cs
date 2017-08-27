namespace Wilf.Facade.ApiFacades
{
    public interface IDatabaseFacade
    {
        bool ClearDatabase();

        int SeedDatabase();
    }
}