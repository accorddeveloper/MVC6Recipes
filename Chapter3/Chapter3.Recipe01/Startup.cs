using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;

namespace Chapter3.Recipe01
{
    public class Startup
    {
        public void Configure(IBuilder app)
        {
            // Setup configuration sources
            var configuration = new Configuration();
            configuration.AddEnvironmentVariables();

            // Set up application services
            app.UseServices(services =>
            {
                // Add MVC services to the services container
                services.AddMvc();
            });

            // Enable Browser Link support
            app.UseBrowserLink();

            // Add static files to the request pipeline
            app.UseStaticFiles();

           
            // Add MVC to the request pipeline
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default", 
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
