using Microsoft.Owin;
using Owin;
using Practice_8.Helper;

[assembly: OwinStartupAttribute(typeof(Practice_8.Startup))]
namespace Practice_8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            SeederDatabase.SeedData();
        }
    }
}
