using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNET.Bootcamp.Startup))]
namespace ASPNET.Bootcamp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
