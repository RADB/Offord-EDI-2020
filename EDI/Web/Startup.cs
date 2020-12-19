using System;
using System.Linq;
using System.Net.Mime;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Newtonsoft.Json;
using EDI.ApplicationCore.Interfaces;
using EDI.Infrastructure.Data;
using EDI.Infrastructure.Identity;
using EDI.Infrastructure.Logging;
using EDI.Web.HealthChecks;
using EDI.Web.Interfaces;
using EDI.Web.Services;
using EDI.Web.Models;
using EDI.Web.Lib;
using EDI.Infrastructure.Interfaces;
using System.Text;
using Blazored.Modal;
using Blazored.Toast;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.Blazor;
using System.Linq.Dynamic.Core;

namespace EDI.Web
{
    public class Startup
    {
        private IServiceCollection _services;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private void ConfigureDBContextServices(IServiceCollection services)
        {
            // use in-memory database
            //ConfigureInMemoryDatabases(services);

            // use real database
            ConfigureProductionServices(services);
        }

        public void ConfigureProductionServices(IServiceCollection services)
        {
            // use real database
            // Requires LocalDB which can be installed with SQL Server Express 2016
            // https://www.microsoft.com/en-us/download/details.aspx?id=54284
            services.AddDbContext<ServiceContext>(c =>
                c.UseSqlServer(Configuration.GetConnectionString("ServiceConnection")), ServiceLifetime.Transient);

            // Add Identity DbContext
            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureDBContextServices(services);

            ConfigureCookieSettings(services);

            services.AddIdentity<ApplicationUser, IdentityRole>()
                        .AddEntityFrameworkStores<AppIdentityDbContext>()
                        .AddRoles<IdentityRole>()
                        .AddRoleManager<RoleManager<IdentityRole>>()
                        .AddEntityFrameworkStores<AppIdentityDbContext>()
                                        .AddDefaultTokenProviders();

            services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));
            services.AddScoped(typeof(IAsyncIdentityRepository), typeof(EfIdentityRepository));

            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IConfigurationService, ConfigurationService>();
            services.AddScoped<IFormService, FormService>();
            services.AddScoped<ISiteService, SiteService>();
            services.AddScoped<ISchoolService, SchoolService>();
            services.AddScoped<IYearService, YearService>();            
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IProvinceService, ProvinceService>();            
            services.AddScoped<ISharedService, SharedService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IChildService, ChildService>();
            services.AddScoped<IMathService, MathService>();
            services.AddScoped<ILinkService, LinkService>();
            services.AddScoped<IFaqService, FaqService>();
            services.AddScoped<ILookupSetService, LookupSetService>();
            services.AddScoped<ILookupSetOptionService, LookupSetOptionService>();
            services.AddScoped<ICoordinatorService, CoordinatorService>();
            services.AddScoped<ITranslationService, TranslationService>();
            services.AddScoped<INewsFeedService, NewsFeedService>();
            services.AddScoped<IQuestionnaireService, QuestionnaireService>();
            services.AddScoped<UserSettings>();
            services.AddScoped<LanguageSettings>();
            services.AddScoped<EDIAppSettings>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.Configure<EDIAppSettings>(Configuration.GetSection("EDIAppSettings"));

            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc(options => options.EnableEndpointRouting = false)
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddRazorPages();
            services.AddServerSideBlazor();

            //services.AddHealthChecks()
            //    .AddCheck<HomePageHealthCheck>("home_page_health_check")
            //    .AddCheck<ApiHealthCheck>("api_health_check");

            services.AddHttpContextAccessor();

            services.AddBlazoredToast();
            services.AddBlazoredModal();
            services.AddSyncfusionBlazor();
        }

        private static void ConfigureCookieSettings(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.Cookie.HttpOnly = true;
                    options.ExpireTimeSpan = TimeSpan.FromHours(1);
                    options.LoginPath = "/Login";
                    options.LogoutPath = "/Logout";
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, LinkGenerator linkGenerator)
        {
            //app.UseDeveloperExceptionPage();
            //app.UseHealthChecks("/health",
            //    new HealthCheckOptions
            //    {
            //        ResponseWriter = async (context, report) =>
            //        {
            //            var result = JsonConvert.SerializeObject(
            //                new
            //                {
            //                    status = report.Status.ToString(),
            //                    errors = report.Entries.Select(e => new
            //                    {
            //                        key = e.Key,
            //                        value = Enum.GetName(typeof(HealthStatus), e.Value.Status)
            //                    })
            //                });
            //            context.Response.ContentType = MediaTypeNames.Application.Json;
            //            await context.Response.WriteAsync(result);
            //        }
            //    });
            //18.2.0.x license
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzIyMjQzQDMxMzgyZTMyMmUzMG1aWllxb0tyN3paWGNGK2NZejZXVVl1WXFINzl6Y0FiWnBCTnJTcVJ6MjA9");
            //18.4.0.30 License
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzY5MjI0QDMxMzgyZTM0MmUzMEVzM1hPUDZQWmV1ZnJZaTNweWh5Rit3NkxqQ2Nnd0RPbTRKb2FLbmg3MTA9");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                ListAllRegisteredServices(app, linkGenerator);
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseRouting();

            app.UseMvcWithDefaultRoute();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }

        private void ListAllRegisteredServices(IApplicationBuilder app, LinkGenerator linkGenerator)
        {
            var homePageLink = linkGenerator.GetPathByPage("/Index");
            var loginLink = linkGenerator.GetPathByAction("SignIn", "Account");
            app.Map("/allservices", builder => builder.Run(async context =>
            {
                var sb = new StringBuilder();
                sb.Append("<a href=\"");
                sb.Append(homePageLink);
                sb.AppendLine("\">Return to site</a> | ");
                sb.Append("<a href=\"");
                sb.Append(loginLink);
                sb.AppendLine("\">Login to site</a>");
                sb.Append("<h1>All Services</h1>");
                sb.Append("<table><thead>");
                sb.Append("<tr><th>Type</th><th>Lifetime</th><th>Instance</th></tr>");
                sb.Append("</thead><tbody>");
                foreach (var svc in _services)
                {
                    sb.Append("<tr>");
                    sb.Append($"<td>{svc.ServiceType.FullName}</td>");
                    sb.Append($"<td>{svc.Lifetime}</td>");
                    sb.Append($"<td>{svc.ImplementationType?.FullName}</td>");
                    sb.Append("</tr>");
                }
                sb.Append("</tbody></table>");
                await context.Response.WriteAsync(sb.ToString());
            }));
        }
    }
}
