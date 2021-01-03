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
            Log.Information("Starting web host");
            var host = CreateHostBuilder(args).Build();

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
                    var logger = loggerFactory.CreateLogger<Program>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                    Log.Error(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();
        }
        //public static void Main(string[] args)
        //{
        //    try
        //    {
        //        Log.Information("Starting web host");

        //        var host = CreateHostBuilder(args).Build();

        //        using (var scope = host.Services.CreateScope())
        //        {
        //            var services = scope.ServiceProvider;
        //            var loggerFactory = services.GetRequiredService<ILoggerFactory>();
        //            try
        //            {
        //                var ServiceContext = services.GetRequiredService<ServiceContext>();
        //                ServiceContextSeed.SeedAsync(ServiceContext, loggerFactory)
        //                                    .Wait();

        //                var userManager = services.GetRequiredService<UserManager<EDIApplicationUser>>();

        //                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
        //                AppIdentityDbContextSeed.SeedAsync(userManager, roleManager).Wait();
        //            }
        //            catch (Exception ex)
        //            {
        //                var logger = loggerFactory.CreateLogger<Program>();
        //                logger.LogError(ex, "An error occurred seeding the DB.");
        //            }
        //        }

        //        host.Run();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log.Fatal(ex, "Host terminated unexpectedly");
        //    }
        //    finally
        //    {
        //        Log.CloseAndFlush();
        //    }

        //}

        //public static IWebHostBuilder CreateHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseSerilog((context, config) =>
        //        {
        //            config.ReadFrom.Configuration(context.Configuration);
        //        })
        //        .UseSetting(WebHostDefaults.DetailedErrorsKey, "true")
        //        .UseStartup<Startup>();

        public static IHostBuilder CreateHostBuilder(string[] args) =>
          Host.CreateDefaultBuilder(args)
              .ConfigureWebHostDefaults(webBuilder =>
              {
                  webBuilder.UseStartup<Startup>();
              });
    }
}
