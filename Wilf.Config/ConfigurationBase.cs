﻿using System;
using Microsoft.Extensions.Configuration;

namespace Wilf.Config
{
    public abstract class ConfigurationBase
    {
        protected IConfigurationRoot GetConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.Production.json")
                .Build();
        }

        protected void RaiseValueNotFoundException(string configurationKey)
        {
            throw new Exception($"appsettings key ({configurationKey}) could not be found.");
        }
    }
}