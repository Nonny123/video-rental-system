using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VRSWeb.Startup))]
namespace VRSWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
