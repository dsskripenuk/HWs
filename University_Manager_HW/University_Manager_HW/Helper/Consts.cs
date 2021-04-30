using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace University_Manager_HW.Helper
{
    public class Consts
    {
        public static string ImagePath
        {
            get { return ConfigurationManager.AppSettings["ImagePath"]; }
        }
    }
}