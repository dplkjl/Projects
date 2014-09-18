using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Akp.Startup))]
namespace Akp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
