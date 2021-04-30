using ASP_NET_11.Helper;
using Hangfire;
using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartupAttribute(typeof(ASP_NET_11.Startup))]
namespace ASP_NET_11
{
    public partial class Startup
    {

        public void PublishMessage()
        {
            SendEmail.SendMail("Hello Pidor!", "matviydima25@gmail.com", "dsskripenuc770@gmail.com");

            //then schedule a job to exec the same method
            BackgroundJob.Schedule(() => PublishMessage(), TimeSpan.FromMilliseconds(1));
        }

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            GlobalConfiguration.Configuration.UseSqlServerStorage("DefaultConnection");
            app.UseHangfireDashboard("/HangfireDashboard", new DashboardOptions
            {
                Authorization = new[] {
                    new AuthorizationHangfireFilter()
            }});

            //var jobId = BackgroundJob.Enqueue(() => Console.WriteLine("Fire-and-forget!"));

            PublishMessage();

            //RecurringJob.AddOrUpdate(
            //    () => SendEmail.SendMail("Hello Pidor!", "bobikbobik716@gmail.com", "dsskripenuc770@gmail.com"),
            //    Cron.GetDescription);

            app.UseHangfireServer();
        }
    }
}
