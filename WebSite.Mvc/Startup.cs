using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSite.Mvc.Startup))]
namespace WebSite.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
