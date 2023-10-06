using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AlaskaResourceData.Data;
using AlaskaResourceData.Services;

namespace AlaskaResourceData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = CreateHostBuilder(args);
            builder.ConfigureServices((services) =>
            {
                services.AddSingleton<AkResourceDataService>();
            });
            var host = builder.Build();

            // Get the configuration
            var configuration = host.Services.GetRequiredService<IConfiguration>();

            // Set the MySQL connection string using SqlHelper
            SqlHelper.ConnectStr = configuration.GetConnectionString("DefaultConnection");

            host.Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}
