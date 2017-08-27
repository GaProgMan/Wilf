using Microsoft.Extensions.Configuration;

namespace Wilf.Config
{
    public class DatabaseConfiguration : ConfigurationBase
    {
        private string CorsPolicyKey = "WilfDb";
        public string GetDatabaseConnectionString()
        {
            return GetConfiguration().GetConnectionString(CorsPolicyKey);
        }
    }
}