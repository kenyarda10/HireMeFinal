using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HireMeFinal.Startup))]
namespace HireMeFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
