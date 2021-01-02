using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;

namespace EDIWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConfigureSeriLog();                                  
            
            CreateHostBuilder(args).Build().Run();
        }

        private static void ConfigureSeriLog()
        {
            //https://github.com/serilog/serilog/wiki/Configuration-Basics
            Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .WriteTo.File(@".\\logs\\logs.txt", Serilog.Events.LogEventLevel.Information, rollingInterval: RollingInterval.Day)
            //.WriteTo.Console(restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Warning, outputTemplate: "{Timestamp:HH:mm} [{Level}] ({ThreadId}) {Message}{NewLine}{Exception}")
            .CreateLogger();
        }
        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
             .UseSerilog()
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}
