using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_12_Practice.Models
{
    public class ListEventsViewModel
    {
        public int Id { get; set; }
        public string Event { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
    }
}