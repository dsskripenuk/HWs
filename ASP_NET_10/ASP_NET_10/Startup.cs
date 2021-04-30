using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_NET_10.Startup))]
namespace ASP_NET_10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
