using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Persistence;

namespace API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            // This will host any services that we create within Services.CreateScope
            using var scope = host.Services.CreateScope(); 
            var services = scope.ServiceProvider;

            // If a database doesn't exist, we'll try to create it. If it fails
            // then we log the failure
            try
            {
                var context = services.GetRequiredService<DataContext>();

                // Create the database migration 
                await context.Database.MigrateAsync();

                // Seed the dummy data (from Persistence.Seed)
                await Seed.SeedData(context);
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, "An error occured during migration");
            }

            // Start the application
            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
