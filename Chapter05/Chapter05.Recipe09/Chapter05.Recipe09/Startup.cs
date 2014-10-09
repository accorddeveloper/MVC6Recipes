using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chapter05.Recipe09.Startup))]
namespace Chapter05.Recipe09
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
