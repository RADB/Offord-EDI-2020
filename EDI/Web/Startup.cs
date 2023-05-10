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
using Microsoft.AspNetCore.Components.Authorization;
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

using Newtonsoft.Json.Serialization;

using Syncfusion.Blazor;

using Serilog; 

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

        
        private void ConfigureDBContextServices(IServiceCollection services)
        {
            // use in-memory database
            //ConfigureInMemoryDatabases(services);

            // use real database
            services.AddDbContext<ServiceContext>(c =>
             c.UseSqlServer(Configuration.GetConnectionString("ServiceConnection")), ServiceLifetime.Transient);

            // Add Identity DbContext
            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            services.AddIdentity<EDIApplicationUser, IdentityRole>()
                        .AddEntityFrameworkStores<AppIdentityDbContext>();
                        //.AddDefaultUI()
                        //.AddRoles<IdentityRole>()
                        //.AddRoleManager<RoleManager<IdentityRole>>()
                        //.AddEntityFrameworkStores<AppIdentityDbContext>()
                        //                .AddDefaultTokenProviders();
            // use for debugging at db level
            services.AddDatabaseDeveloperPageExceptionFilter();
        }

        private static void ConfigureIdentityPasswordComplexity(IServiceCollection services)
        {
            services.Configure<IdentityOptions>(options =>
            {
                //https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity-configuration?view=aspnetcore-5.0
                // Default Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 2;
                options.Password.RequiredUniqueChars = 1;
            });
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // this is used in eshop instead of configureCookie
            //services.AddCookieSettings();            
            //ConfigureSession(services)           

            ConfigureDBContextServices(services);

            ConfigureIdentityPasswordComplexity(services);
            //2021
            //ConfigureCookieSettings(services);
            //2021
            //services.AddAuthorization();

            /* Core Services */
            services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));
            services.AddScoped(typeof(IAsyncIdentityRepository), typeof(EfIdentityRepository));
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddTransient<IEmailSender, EmailSender>();            
            //services.AddControllers().AddJsonOptions(option => { option.JsonSerializerOptions.PropertyNamingPolicy = null; option.JsonSerializerOptions.MaxDepth = 256; });

            ConfigureApplicationServices(services);
            

            // Added
            services.AddMemoryCache();

            services.AddRazorPages();
            //services.AddRazorPages()
            //.AddRazorPagesOptions(options =>
            //{
            //    options.Conventions.AuthorizePage("/LearningResources/Create");
            //    options.Conventions.AuthorizePage("/LearningResources/Edit");
            //    options.Conventions.AuthorizePage("/LearningResources/Delete");
            //    options.Conventions.AuthorizePage("/ResourceLists/Create");
            //    options.Conventions.AuthorizePage("/ResourceLists/Edit");
            //    options.Conventions.AuthorizePage("/ResourceLists/Delete");
            //    options.Conventions.AllowAnonymousToPage("/Index");
            //});

            services.Configure<EDIAppSettings>(Configuration.GetSection("EDIAppSettings"));

            // changed to Add method
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddHttpContextAccessor();
      
            /* Blazor Services */
            services.AddServerSideBlazor();
            //2021 Added 
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<EDIApplicationUser>>();
            services.AddBlazoredSessionStorage();
            services.AddBlazoredToast();
            services.AddBlazoredModal();
            services.AddSyncfusionBlazor();            
            services.AddControllers().AddNewtonsoftJson(options => {
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;                                
            });                            
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env, LinkGenerator linkGenerator)
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //18.4.0.30 License
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzY5MjI0QDMxMzgyZTM0MmUzMEVzM1hPUDZQWmV1ZnJZaTNweWh5Rit3NkxqQ2Nnd0RPbTRKb2FLbmg3MTA9");

            //19 License Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDIyOTIxQDMxMzkyZTMxMmUzMExFWjlKaXdLekh3ekdGSmRkNjlhMjFtT2lvTTdZSnpVOVpqZy9Rcm5udEU9");
            //19.2.0.60
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDk4MTQxQDMxMzkyZTMyMmUzMFdKN3FHb3NYY1kvU2dSN0N5b2ZBSjRraE00VlZHNThreUxoeldsU3Vud0k9");
            //19.3.0.43
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTMzNTE3QDMxMzkyZTMzMmUzMFRsd25OVDJaKzEyZk1PRDlVNVRoVGZCbFhiU3JqNmVqOGdvdnFiNDZ5WGc9");
            //19.4.0.41
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTYwNDgyQDMxMzkyZTM0MmUzMFJMRkJVNkxzeTdjeEM4S3BTTG50NFI0QkdlZzJwUWZLcEJURlpNbDk4OTg9");
            //20.1.0.50
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjIyMzAzQDMyMzAyZTMxMmUzMEdoeDhNZTZ5Vm1zNGIwRWJZRTFLSzFlZFdYQm1LelpXMG4xY3hOd3FmRkU9");
            //20.3.0.49 - check JS reference in _host file in Pages directory - update bootstrap5 and JS source to version of syncfusion controls 
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzM5NDUwQDMyMzAyZTMzMmUzME4zZkJYSENEVUd4WnZ6Zzk5MDhaNnh2dmFNaTY0TGVWcDBpSHUxZGI2Nkk9");
            //20.4.0.38
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Nzk0NTE0QDMyMzAyZTM0MmUzMEdtY0crUlB3a3ZDWTBsejl6dEhTLzVFZEtoc2hBZXpQNy83QVNIM1JXSDA9");
            //21.1.0.35
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTYzNDY4OUAzMjMxMmUzMTJlMzMzNVpYYURySGQ2ZFJMb0ZyamJidlVkU2dnNEJOcDgzaVhoNkc4MzFCamEzdjQ9");
            //21.2.4
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo + DSMBaFt + QHJqUU1hXk5Hd0BLVGpAblJ3T2ZQdVt5ZDU7a15RRnVfR1xjSHxSckBkUX9bcQ ==; Mgo + DSMBPh8sVXJ1S0R + WFpFdEBBXHxAd1p / VWJYdVt5flBPcDwsT3RfQF5jTH9Td0diXXpZeHVcRw ==; ORg4AjUWIQA / Gnt2VFhiQlVPd11dXmJWd1p / THNYflR1fV9DaUwxOX1dQl9gSXtSdkRhWHtbd3xWR2E =; MTk5ODUxMEAzMjMxMmUzMjJlMzRLSXpNTVJrbGtWelhRK1FZUTJMbG5lUDBlazErdy96QzlyRzA4cDhzbVo4PQ ==; MTk5ODUxMUAzMjMxMmUzMjJlMzRLU2tzY1pZajBFNlJFU01ndWVLL0lmUkNvMTkycEtFeGx4WllsZXNUZVNrPQ ==; NRAiBiAaIQQuGjN / V0d + Xk9AfV5AQmBIYVp / TGpJfl96cVxMZVVBJAtUQF1hSn5Wd0ViW35adXNcR2Nd; MTk5ODUxM0AzMjMxMmUzMjJlMzRVdXpKd2Vkcnl2ZFNjeEI4R0w3L2l5T0dxeGtsRkJleVJvKzIwcGxDWWJ3PQ ==; MTk5ODUxNEAzMjMxMmUzMjJlMzRkejBNVElINEN0NVJoL1l4WXZBTVlrcWc0QW9tdGUrR3JRZUJkUmJWZ0Y4PQ ==; Mgo + DSMBMAY9C3t2VFhiQlVPd11dXmJWd1p / THNYflR1fV9DaUwxOX1dQl9gSXtSdkRhWHtbd31dTmE =; MTk5ODUxNkAzMjMxMmUzMjJlMzRWNlRlWUMwaEFMVGMvTFpOdmF4MnpVRmY2ckl6eWN6MlpOck1LbGxWMmFzPQ ==; MTk5ODUxN0AzMjMxMmUzMjJlMzRva1JMWnhDYkVocVpMajBhVUxEdm5IZEcweGhGVzdRTDJzRGZrTnZVQXFRPQ ==; MTk5ODUxOEAzMjMxMmUzMjJlMzRVdXpKd2Vkcnl2ZFNjeEI4R0w3L2l5T0dxeGtsRkJleVJvKzIwcGxDWWJ3PQ ==");
            // Verified
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseShowAllServicesMiddleware(); // Ardalis.ListStartupServices
                app.UseMigrationsEndPoint();    // .net5 upgrade
                //app.UseWebAssemblyDebugging(); // doesnt exist in serverside 

                //ListAllRegisteredServices(app, linkGenerator);
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
                //app.UseHttpsRedirection();
            }
            // This will make the HTTP requests log as rich logs instead of plain text.  must be before userouting
            app.UseSerilogRequestLogging();

            //app.UseBlazorFrameworkFiles(); // webassembly
            app.UseStaticFiles();
            app.UseRouting();
            
            //2021
            //app.UseCookiePolicy();
            app.UseAuthentication();            
            app.UseAuthorization();
            //app.UseSession();
                        
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

        }


        private static void ConfigureApplicationServices(IServiceCollection services)
        {
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
            // used to store various states
            services.AddScoped<StateContainer>();
        }
        private static void ConfigureSession(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.Cookie.Name = "EDI";
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.IsEssential = true;
            });
        }

        private static void ConfigureCookieSettings(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                //options.HttpOnly = Microsoft.AspNetCore.CookiePolicy.HttpOnlyPolicy.Always; //
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None; // was none                
            });
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    //TODO need to check that.
            //    //options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});

            //services.ConfigureApplicationCookie(options =>
            //{
            //    options.Cookie.HttpOnly = true;
            //    options.ExpireTimeSpan = TimeSpan.FromHours(1);
            //    options.LoginPath = "/Login";
            //    options.LogoutPath = "/Logout";
            //    options.Cookie = new CookieBuilder
            //    {
            //        IsEssential = true // required for auth to work without explicit user consent; adjust to suit your privacy policy
            //    };
            //});

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //    .AddCookie(options =>
            //    {
            //        options.Cookie.HttpOnly = true;
            //        //options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;  // TODO: change to always once in production on SSL
            //        options.Cookie.SameSite = SameSiteMode.Lax;
            //    });
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
