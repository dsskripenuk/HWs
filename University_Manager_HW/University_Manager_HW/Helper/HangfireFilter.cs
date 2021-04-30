using Hangfire.Annotations;
using Hangfire.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University_Manager_HW.Helper
{
    public class HangfireFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize([NotNull] DashboardContext context)
        {
            return HttpContext.Current.User.IsInRole("Admin");
        }
    }
}
