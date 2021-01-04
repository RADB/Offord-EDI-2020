using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using EDI.Infrastructure.Data;
using EDI.Infrastructure.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Serilog;


namespace EDI.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        //public static void Main(string[] args)
        {
            ConfigureSeriLog();

            //CreateHostBuilder(args).Build().Run();

            // seed the database
            var host = CreateHostBuilder(args).Build();

            await SeedDatabases(host);

            host.Run();
        }

        private static async Task SeedDatabases(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                try
                {
                    var serviceContext = services.GetRequiredService<ServiceContext>();
                    //ServiceContextSeed.SeedAsync(serviceContext, loggerFactory).Wait();
                    await ServiceContextSeed.SeedAsync(serviceContext, loggerFactory);

                    var userManager = services.GetRequiredService<UserManager<EDIApplicationUser>>();
                    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                    //AppIdentityDbContextSeed.SeedAsync(userManager, roleManager).Wait();
                    await AppIdentityDbContextSeed.SeedAsync(userManager, roleManager);
                }
                catch (Exception ex)
                {
                    //var logger = loggerFactory.CreateLogger<Program>();
                    //logger.LogError(ex, "An error occurred seeding the DB.");
                    Log.Error(ex, "An error occurred seeding the DB.");
                }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
          Host.CreateDefaultBuilder(args)
              .UseSerilog()
              .ConfigureWebHostDefaults(webBuilder =>
              {
                  webBuilder.UseStartup<Startup>();
              });
        private static void ConfigureSeriLog()
        {
            //https://github.com/serilog/serilog/wiki/Configuration-Basics
            Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .WriteTo.File(@".\\logs\\logs.txt", Serilog.Events.LogEventLevel.Information, rollingInterval: RollingInterval.Day)
            //.WriteTo.Console(restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Warning, outputTemplate: "{Timestamp:HH:mm} [{Level}] ({ThreadId}) {Message}{NewLine}{Exception}")
            .CreateLogger();
        }
    }
}
