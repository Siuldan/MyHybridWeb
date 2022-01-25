using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyHybridWeb.Startup))]
namespace MyHybridWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
