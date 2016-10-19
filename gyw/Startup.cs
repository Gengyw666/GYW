using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gyw.Startup))]
namespace gyw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
