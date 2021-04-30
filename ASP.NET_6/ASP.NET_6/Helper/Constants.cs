using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ASP.NET_6.Helper
{
    public static class Constants
    {
        public static string ImagePath
        {
            get { return ConfigurationManager.AppSettings["ImagePath"]; }
        }
    }
}