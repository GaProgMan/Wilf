namespace Wilf.Facade
{
    public interface IApiFacade
    {
        string ApiUseageString();
        bool DropData();
        int SeedData();
    }
}