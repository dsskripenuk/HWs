using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.NET_12_Practice.Startup))]
namespace ASP.NET_12_Practice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
