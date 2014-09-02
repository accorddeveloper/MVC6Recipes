using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chapter05.Recipe10.Web.Startup))]
namespace Chapter05.Recipe10.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
