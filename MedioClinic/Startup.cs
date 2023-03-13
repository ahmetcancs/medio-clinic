using Kentico.Activities.Web.Mvc;
using Kentico.CampaignLogging.Web.Mvc;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Kentico.Newsletters.Web.Mvc;
using Kentico.OnlineMarketing.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Scheduler.Web.Mvc;
using Kentico.Web.Mvc;
using MedioClinic.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlankSiteCore
{
    public class Startup
    {
        public const string DEFAULT_WITHOUT_LANGUAGE_PREFIX_ROUTE_NAME = "DefaultWithoutLanguagePrefix";
        public const string CONSTRAINT_FOR_NON_ROUTER_PAGE_CONTROLLERS = "Home|Doctors|Contact";
        
        public IWebHostEnvironment Environment { get; }


        public Startup(IWebHostEnvironment environment)
        {
            Environment = environment;
        }


        
        public void ConfigureServices(IServiceCollection services)
        {
            
            var kenticoServiceCollection = services.AddKentico(features =>
            {
                 features.UsePageBuilder();
                 features.UseActivityTracking();
                 features.UseABTesting();
                 features.UseWebAnalytics();
                 features.UseEmailTracking();
                 features.UseCampaignLogger();
                 features.UseScheduler();
                 features.UsePageRouting();
            });

            if (Environment.IsDevelopment())
            {
                kenticoServiceCollection.SetAdminCookiesSameSiteNone();

             
                kenticoServiceCollection.DisableVirtualContextSecurityForLocalhost();
            }

            services.AddAuthentication();
             services.AddAuthorization();
            
            
            services.AddMedioClinicServices(); //IServiceCollectionExtensions (Repositories)

            services.AddControllersWithViews();
        }

        
        public void Configure(IApplicationBuilder app)
        {
            if (Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePagesWithReExecute("/error/{0}");
            app.UseStaticFiles();

            app.UseKentico();

            app.UseCookiePolicy();

            app.UseCors();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {


                /* endpoints.MapGet("/", async context =>
                 {
                     await context.Response.WriteAsync("The site has not been configured yet.");
                 });*/

               // endpoints.Kentico().MapRoutes();
                endpoints.MapControllerRoute(
                   name: "error",
                   pattern: "error/{code}",
                   defaults: new { controller = "HttpErrors", action = "Error" }
                );
                endpoints.MapDefaultControllerRoute();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Doctors}/{action=persons}/{id?}");




               
            });
        }
    }
}
