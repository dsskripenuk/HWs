using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Practice_4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
