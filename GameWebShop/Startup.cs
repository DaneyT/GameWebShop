using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameWebShop.Startup))]
namespace GameWebShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
