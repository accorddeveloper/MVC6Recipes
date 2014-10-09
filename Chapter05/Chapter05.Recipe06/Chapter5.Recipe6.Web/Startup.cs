using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;
using Chapter5.Recipe6.Dal.Context;

namespace Chapter5.Recipe6.Web
{
    public class Startup
    {
        public void Configure(IBuilder app)
        {
            // Setup configuration sources
            //var configuration = new Configuration();
            //configuration.AddJsonFile("config.json");
            //configuration.AddEnvironmentVariables();

            // Set up application services
            app.UseServices(services =>
            {
                // Add EF services to the services container
                //services.AddEntityFramework()
                //    .AddSqlServer();

                // Configure DbContext
                //services.SetupOptions<DbContextOptions>(options =>
                //{
                //    options.UseSqlServer(configuration.Get("Data:DefaultConnection:ConnectionString"));
                // });


                //try and create database if it does not exist
                using (var context = new ArtistContext())
                {
                    context.Database.EnsureCreated();
                }

                // Add MVC services to the services container
                services.AddMvc();
            });



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
