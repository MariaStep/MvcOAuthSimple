using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcOAuthSimple.Startup))]
namespace MvcOAuthSimple
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
