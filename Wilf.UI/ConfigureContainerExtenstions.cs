using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Wilf.Config;
using Wilf.DAL;
using Wilf.Persistence;

namespace Wilf.UI
{
    /// <summary>
    /// This class is based on some of the suggestions bty K. Scott Allen in
    /// his NDC 2017 talk https://www.youtube.com/watch?v=6Fi5dRVxOvc
    /// </summary>
    public static class ConfigureContainerExtenstions
    {
        private static string DbConnectionString => new DatabaseConfiguration().GetDatabaseConnectionString();

        public static void AddDbContext(this IServiceCollection serviceCollection, string connectionString = null)
        {
            serviceCollection.AddDbContext<WilfContext>(options =>
                options.UseSqlite(connectionString ?? DbConnectionString));
        }

        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ISeasonService, SeasonService>();
        }

        public static void AddCustomizedMvc(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvc();
        }
    }
}