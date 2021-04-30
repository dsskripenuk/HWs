using Hangfire.Annotations;
using Hangfire.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_NET_11.Helper
{
    public class AuthorizationHangfireFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize([NotNull] DashboardContext context)
        {
            //return HttpContext.Current.User.IsInRole("Admin");        
            return HttpContext.Current.User.Identity.IsAuthenticated;        
        }
    }
}