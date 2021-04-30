using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_Practice_4.Models
{
    public class AnimeViewModel
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string DateOfRelease { get; set; }
        public int Rating { get; set; }
        public string URL_Image { get; set; }
    }
}