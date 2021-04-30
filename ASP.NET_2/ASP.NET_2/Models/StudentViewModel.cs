using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_2.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; } 
        public int Age { get; set; }
        public string Address { get; set; }
        public string URL_Img { get; set; }
    }
}