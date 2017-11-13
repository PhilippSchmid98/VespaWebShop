using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VespaWebShop.Startup))]
namespace VespaWebShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
