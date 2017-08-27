namespace Wilf.Facade.ApiFacades
{
    public interface IBaseApiFacade
    {
        string ApiUseageString();
        bool DropData();
        int SeedData();
    }
}