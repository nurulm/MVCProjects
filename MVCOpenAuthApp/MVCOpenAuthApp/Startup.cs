using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCOpenAuthApp.Startup))]
namespace MVCOpenAuthApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
