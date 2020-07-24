using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorUsersRoles.Areas.Identity;
using BlazorUsersRoles.Data;
using Syncfusion.Blazor;

namespace BlazorUsersRoles
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
    
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
/*            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("SQLLite")));
*/
            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddSingleton<WeatherForecastService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjYzMDEzQDMxMzgyZTMxMmUzMEVRTy9EZ0g2VnNqVXE3cWI5MERTSU43aEJsUlZjcEx3SmlBV1dpdURFRG89;MjYzMDE0QDMxMzgyZTMxMmUzMFFlMTBGZzJkMy9vYS9yMnRjWlVuOUVwQTZoVUsvbnFLcVNFempoT0ZIeGs9;MjYzMDE1QDMxMzgyZTMxMmUzMFJscUV5R1pVWnIzMGF1cGpweDVhQ0ROd2pPYTdPU2NGdTEzODRHTUZhekU9;MjYzMDE2QDMxMzgyZTMxMmUzMFh0V3RNYUo0dkxwNCtrZmFkLzg5N3lIdjYwbjBTRkRYbUtPUkZzWmhWajg9;MjYzMDE3QDMxMzgyZTMxMmUzMGNaUmFuQ3JhUXpQYWlHNlVMQTVpc0pOUEcxQXYzdVdvcjNRTWpxSXdHQ1k9;MjYzMDE4QDMxMzgyZTMxMmUzMEc2ZnZ5QnAwbjZ0ZHA3bzIzTjFHUkx6U1hEZWp6Q04zS3pFU3hkQjVYZ2s9");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
