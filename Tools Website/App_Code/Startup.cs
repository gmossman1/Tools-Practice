using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tools_Website.Startup))]
namespace Tools_Website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
