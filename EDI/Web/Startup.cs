using Ardalis.ListStartupServices;

using Blazored.Modal;
using Blazored.SessionStorage;
using Blazored.Toast;

using EDI.ApplicationCore.Interfaces;
using EDI.Infrastructure.Data;
using EDI.Infrastructure.Identity;
using EDI.Infrastructure.Interfaces;
using EDI.Infrastructure.Logging;
using EDI.Web.Controllers;
using EDI.Web.HealthChecks;
using EDI.Web.Interfaces;
using EDI.Web.Services;
using EDI.Web.Models;
using EDI.Web.Lib;

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;

using Newtonsoft.Json;

using Syncfusion.Blazor;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Net.Http;
using System.Net.Mime;
using System.Text;

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

        //public void ConfigureDevelopmentServices(IServiceCollection services)
        //{
        //    // use in-memory database
        //    ConfigureInMemoryDatabases(services);

        //    // use real database
        //    //ConfigureProductionServices(services);
        //}

        //public void ConfigureDockerServices(IServiceCollection services)
        //{
        //    services.AddDataProtection()
        //        .SetApplicationName("EDI")
        //        .PersistKeysToFileSystem(new DirectoryInfo(@"./"));

        //    ConfigureDevelopmentServices(services);
        //}
        //private void ConfigureInMemoryDatabases(IServiceCollection services)
        //{
        //    // use in-memory database
        //    services.AddDbContext<CatalogContext>(c =>
        //        c.UseInMemoryDatabase("Catalog"));

        //    // Add Identity DbContext
        //    services.AddDbContext<AppIdentityDbContext>(options =>
        //        options.UseInMemoryDatabase("Identity"));

        //    ConfigureServices(services);
        //}
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
                c.UseSqlServer(Configuration.GetConnectionString("ServiceConnection")));
            //, ServiceLifetime.Transient);

            // Add Identity DbContext
            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            // TODO 2020-12-31 Andrew Renner - publish issue - potentially as this was not being called
            ConfigureServices(services);
        }
        //public void ConfigureTestingServices(IServiceCollection services)
        //{
        //    ConfigureInMemoryDatabases(services);
        //}

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // this is used in eshop instead of configureCookie
            //services.AddCookieSettings();
            ConfigureCookieSettings(services);

            ConfigureDBContextServices(services);
                        
            services.AddIdentity<ApplicationUser, IdentityRole>()
                        .AddEntityFrameworkStores<AppIdentityDbContext>()
                        //.AddDefaultUI()
                        .AddRoles<IdentityRole>()
                        .AddRoleManager<RoleManager<IdentityRole>>()
                        .AddEntityFrameworkStores<AppIdentityDbContext>()
                                        .AddDefaultTokenProviders();

            /* Core Services */
            services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));
            services.AddScoped(typeof(IAsyncIdentityRepository), typeof(EfIdentityRepository));
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddTransient<IEmailSender, EmailSender>();

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
            services.AddScoped<IReflectionService, ReflectionService>();
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
            services.AddScoped<FileManagerController>();

            // Added
            services.AddMemoryCache();

            //services.AddRouting(options =>
            //{
            //    // Replace the type and the name used to refer to it with your own
            //    // IOutboundParameterTransformer implementation
            //    options.ConstraintMap["slugify"] = typeof(SlugifyParameterTransformer);
            //});
            //services.AddMvc(options =>
            //{
            //    options.Conventions.Add(new RouteTokenTransformerConvention(
            //             new SlugifyParameterTransformer()));

            //});
            //services.AddControllersWithViews();

            services.AddRazorPages();
            //(options =>
            //{
            //    options.Conventions.AuthorizePage("/Basket/Checkout");
            //});

            // changed to Add method
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddHttpContextAccessor();




            //services.AddHealthChecks();
            //    .AddCheck<HomePageHealthCheck>("home_page_health_check")
            //    .AddCheck<ApiHealthCheck>("api_health_check");            
            //services.Configure<ServiceConfig>(config =>
            //{
            //    config.Services = new List<ServiceDescriptor>(services);

            //    config.Path = "/allservices";
            //});
            services.Configure<EDIAppSettings>(Configuration.GetSection("EDIAppSettings"));

            //var baseUrlConfig = new BaseUrlConfiguration();
            //Configuration.Bind(BaseUrlConfiguration.CONFIG_NAME, baseUrlConfig);
            //services.AddScoped<BaseUrlConfiguration>(sp => baseUrlConfig);
            //// Blazor Admin Required Services for Prerendering
            //services.AddScoped<HttpClient>(s => new HttpClient
            //{
            //    BaseAddress = new Uri(baseUrlConfig.WebBase)
            //});

            // used to store various states
            services.AddSingleton<StateContainer>();

            //services.AddMvc(options => options.EnableEndpointRouting = false)
            //    .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);


            /* Blazor Services */
            services.AddServerSideBlazor();
            services.AddBlazoredSessionStorage();
            services.AddBlazoredToast();
            services.AddBlazoredModal();
            services.AddSyncfusionBlazor();

            // use for debugging at db level
            services.AddDatabaseDeveloperPageExceptionFilter();
        }

        private static void ConfigureCookieSettings(IServiceCollection services)
        {
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    //options.HttpOnly = Microsoft.AspNetCore.CookiePolicy.HttpOnlyPolicy.Always; //
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.Lax; // was none                
            //});
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                //TODO need to check that.
                //options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.Strict;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromHours(1);
                options.LoginPath = "/Login";
                options.LogoutPath = "/Logout";
                options.Cookie = new CookieBuilder
                {
                    IsEssential = true // required for auth to work without explicit user consent; adjust to suit your privacy policy
                };
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.Cookie.HttpOnly = true;
                    options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;  // TODO: change to always once in production on SSL
                    options.Cookie.SameSite = SameSiteMode.Lax;
                });
            //services.AddAuthentication(
            //    CookieAuthenticationDefaults.AuthenticationScheme)
            //    .AddCookie(options =>
            //    {
            //        options.Cookie.HttpOnly = true;
            //        options.ExpireTimeSpan = TimeSpan.FromHours(1);
            //        options.LoginPath = "/Login";
            //        options.LogoutPath = "/Logout";                    
            //    });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env, LinkGenerator linkGenerator)
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseHealthChecks("/health",
            //    new HealthCheckOptions
            //    {
            //        ResponseWriter = async (context, report) =>
            //        {
            //            var result = new
            //            {
            //                status = report.Status.ToString(),
            //                errors = report.Entries.Select(e => new
            //                {
            //                    key = e.Key,
            //                    value = Enum.GetName(typeof(HealthStatus), e.Value.Status)
            //                })
            //            }.ToJson();
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
                app.UseShowAllServicesMiddleware(); // Ardalis.ListStartupServices
                app.UseMigrationsEndPoint();
                //app.UseWebAssemblyDebugging(); // doesnt exist in serverside 

                //ListAllRegisteredServices(app, linkGenerator);
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            

            app.UseHttpsRedirection();
            //app.UseBlazorFrameworkFiles(); // webassembly
            app.UseStaticFiles();
            app.UseRouting();

            app.UseCookiePolicy();
            app.UseAuthentication();
            // added 2020-12-31
            app.UseAuthorization();


            //app.UseMvcWithDefaultRoute();

            app.UseEndpoints(endpoints =>
            {
                // andrew 2020-12-21
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute("default", "{controller:slugify=Home}/{action:slugify=Index}/{id?}");
            //    endpoints.MapRazorPages();
            //    endpoints.MapHealthChecks("home_page_health_check");
            //    endpoints.MapHealthChecks("api_health_check");
            //    //endpoints.MapBlazorHub("/admin");
            //    endpoints.MapFallbackToFile("index.html");
            //});
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
