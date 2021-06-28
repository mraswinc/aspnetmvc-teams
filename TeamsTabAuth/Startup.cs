using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamsTabAuth.Startup))]
namespace TeamsTabAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
