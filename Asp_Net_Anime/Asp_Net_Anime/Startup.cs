using Asp_Net_Anime.Helper;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asp_Net_Anime.Startup))]
namespace Asp_Net_Anime
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
