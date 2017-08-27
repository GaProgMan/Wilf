namespace Wilf.DAL
{
    public interface IDatabaseService
    {
        /// <summary>
        /// Used to drop all pre-existing data from the database
        /// </summary>
        /// <returns>Indicates the success or failure</returns>
        bool ClearDatabase();

        /// <summary>
        /// Used to insert all seed data into the database
        /// </summary>
        /// <returns></returns>
        int SeedDatabase();
    }
}