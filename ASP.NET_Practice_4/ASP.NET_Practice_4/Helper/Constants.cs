using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ASP.NET_Practice_4.Helper
{
    public class Constants
    {
        public static string ImagePath
        {
            get { return ConfigurationManager.AppSettings["ImagePath"]; }
        }
    }
}