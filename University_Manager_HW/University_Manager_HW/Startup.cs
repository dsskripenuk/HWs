using Hangfire;
using Microsoft.Owin;
using Owin;
using University_Manager_HW.Helper;

[assembly: OwinStartupAttribute(typeof(University_Manager_HW.Startup))]
namespace University_Manager_HW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            GlobalConfiguration.Configuration.UseSqlServerStorage("DefaultConnection");

            app.UseHangfireDashboard("/HangfireDashboard", new DashboardOptions
            {
                Authorization = new[] { new HangfireFilter() }
            });

            app.UseHangfireServer();
        }
    }
}
