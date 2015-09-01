using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Diagnostics;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;
using Microsoft.Framework.Logging.Console;
using Microsoft.Framework.Configuration;
using Microsoft.Framework.Configuration.Helper;
using Microsoft.Framework.Runtime;

namespace Recipe02.Web
{
    public class Startup
    {
        // Beta 4
        //public Startup(IHostingEnvironment env)
        //{
        //    // Setup configuration sources.
        //    var configuration = new Configuration()
        //        .AddJsonFile("config.json")
        //        .AddJsonFile($"config.{env.EnvironmentName}.json", optional: true);
        //    }
        //    configuration.AddEnvironmentVariables();
        //    Configuration = configuration;
        //}

        // Beta 6
        public Startup(IHostingEnvironment env,  IApplicationEnvironment appEnv)
        {
            // Setup configuration sources.
            var builder = new ConfigurationBuilder(appEnv.ApplicationBasePath)
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime.
        public void ConfigureServices(IServiceCollection services)
        {

            // Beta 4
            //services.Configure<AppSettings>(Configuration.GetSubKey("AppSettings"));

            // Beta 6
            services.Configure<Recipe02.Web.AppSettings>(Configuration.GetConfigurationSection("AppSettings"));

            // Add MVC services to the services container.
            services.AddMvc();

        }

        // Configure is called after ConfigureServices is called.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerfactory)
        {
            // Configure the HTTP request pipeline.

            // Add the console logger.
            loggerfactory.AddConsole();

            // Add the following to the request pipeline only in development environment.
            if (env.IsEnvironment("Development"))
            {
                app.UseBrowserLink();
                //app.UseErrorPage(ErrorPageOptions.ShowAll);
                var errorPageOptions = new ErrorPageOptions();
                errorPageOptions.SourceCodeLineCount = 10;
                app.UseErrorPage(errorPageOptions);
            }
            else
            {
                // Add Error handling middleware which catches all application specific errors and
                // send the request to the following path or controller action.
                app.UseErrorHandler("/Home/Error");
            }

            // Add static files to the request pipeline.
            app.UseStaticFiles();

            // Add MVC to the request pipeline.
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "defaultWithArea",
                    template: "{controller}/{action}/{area}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });

                // Uncomment the following line to add a route for porting Web API 2 controllers.
                // routes.MapWebApiRoute("DefaultApi", "api/{controller}/{id?}");
            });
        }
    }
}
