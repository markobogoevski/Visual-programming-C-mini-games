using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using MyProject.Data;

namespace MyProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var host = CreateWebHostBuilder(args).Build();

               RunSeeding(host);

                host.Run();
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void RunSeeding(IWebHost host)
        {
            var scopeFactory = host.Services.GetService<IServiceScopeFactory>();
            using (var scope = scopeFactory.CreateScope()) 
            {
                var seeder = scope.ServiceProvider.GetService<DutchSeeder>();
                seeder.SeedAsync().Wait();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(CreateConf)
                .UseStartup<Startup>();

        private static void CreateConf(WebHostBuilderContext ctx, IConfigurationBuilder builder)
        {
            //clear default conf
            builder.Sources.Clear();
            builder.AddJsonFile("config.json", false, true);
        }
    }
}
