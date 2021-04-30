using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.NET_12.Startup))]
namespace ASP.NET_12
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
