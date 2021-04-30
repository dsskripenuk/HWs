using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_HW_2.Models
{
    public class AddCardViewModel
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string FullDescription { get; set; }
        public string ShortDescription { get; set; }
        public string Img { get; set; }
    }
}