using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Wilf.Config;
using Wilf.DAL;
using Wilf.Facade;
using Wilf.Facade.ApiFacades;
using Wilf.Facade.ControllerFacades;
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

        public static void AddFacades(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IBaseApiFacade, BaseApiFacade>();
            serviceCollection.AddTransient<IHomeFacade, HomeFacade>();
            serviceCollection.AddTransient<IDatabaseFacade, DatabaseFacade>();
        }

        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ISeasonService, SeasonService>();
            serviceCollection.AddTransient<IDatabaseService, DatabaseService>();
        }

        public static void AddCustomizedMvc(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvc();
        }

        public static void AddFeatureFolders(this IServiceCollection serviceCollection)
        {
            serviceCollection.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationExpanders.Add(new FeatureLocationExpander());
            });
        }
    }
}