using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MapApplications.Startup))]
namespace MapApplications
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
