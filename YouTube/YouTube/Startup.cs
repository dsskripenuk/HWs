using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YouTube.Startup))]
namespace YouTube
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
