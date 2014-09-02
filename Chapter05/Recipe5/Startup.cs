using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Recipe5.Startup))]
namespace Recipe5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
