using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Diagnostics;
using Microsoft.AspNet.Hosting;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;
using Microsoft.Framework.Configuration;
using Microsoft.Framework.Runtime;
using Recipe05.Web.Services;

namespace Recipe05.Web
{
    public class Startup
    {
        private string _rootPath;
        public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
        {
            _rootPath = appEnv.ApplicationBasePath;
            var builder = new ConfigurationBuilder(_rootPath)
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();
        }

        public IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            var descriptor = new ServiceDescriptor(typeof(IHitCounterService), new HitCounterService(_rootPath));
            services.Add(descriptor);
        }

        // Configure is called after ConfigureServices is called.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerfactory)
        {
            loggerfactory.AddConsole();
            if (env.IsEnvironment("Development"))
            {
                app.UseBrowserLink();
                app.UseErrorPage(ErrorPageOptions.ShowAll);
            }
            else
            {
                app.UseErrorHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
