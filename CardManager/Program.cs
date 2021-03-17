﻿using CardManager.DAL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace CardManager
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfigureServices(GetConfiguration());

            serviceProvider.GetRequiredService<CardManager>().Run();
        }

        static IConfiguration GetConfiguration()
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            return configurationBuilder.Build();
        }

        static IServiceProvider ConfigureServices(IConfiguration config)
        {
            string digimonConnectionString = config.GetConnectionString("DigimonDB");

            IServiceCollection services = new ServiceCollection();
            return services.AddSingleton<CardManager>()
                           .AddTransient<ISetDAO>(s => new SqlSetDAO(digimonConnectionString))
                           .AddTransient<ICardDAO>(s => new SqlCardDAO(digimonConnectionString))
                           .AddTransient<IPrintingDAO>(s => new SqlPrintingDAO(digimonConnectionString))
                           .BuildServiceProvider();
        }
    }
}
