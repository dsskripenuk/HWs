using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Asp_Net_Anime.Helper
{
    public static class Constants
    {
        public static string ImagePath
        {
            get { return ConfigurationManager.AppSettings["ImagePath"]; }
        }
    }
}