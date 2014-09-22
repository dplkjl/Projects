using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AKP2withoutLightspeed.Startup))]
namespace AKP2withoutLightspeed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
