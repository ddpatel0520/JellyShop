using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JellyShop.WebUI.Startup))]
namespace JellyShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
