using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;


namespace Chapter05.Recipe11.Web
{
    public class Startup
    {
        public void Configure(IBuilder app)
        {


            // Set up application services
            app.UseServices(services =>
            {
                
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
