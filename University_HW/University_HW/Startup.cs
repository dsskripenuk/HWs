using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(University_HW.Startup))]
namespace University_HW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
