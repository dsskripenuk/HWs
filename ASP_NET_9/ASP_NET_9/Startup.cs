using ASP_NET_9.Helper;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_NET_9.Startup))]
namespace ASP_NET_9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //SeederDatabase.SeedData();
        }
    }
}
