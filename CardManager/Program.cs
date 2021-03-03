using Microsoft.Extensions.Configuration;
using System.IO;

namespace CardManager
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfigurationRoot config = configurationBuilder.Build();

            string digimonConnectionString = config.GetConnectionString("DigimonDB");
        }
    }
}
