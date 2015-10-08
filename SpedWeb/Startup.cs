using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpedWeb.Startup))]
namespace SpedWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
