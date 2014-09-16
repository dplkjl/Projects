using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KJL1.Startup))]
namespace KJL1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
