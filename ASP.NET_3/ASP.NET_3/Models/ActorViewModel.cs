using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_3.Models
{
    public class ActorViewModel
    {
        public int id { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }

        public string BirthDate { get; set; }

        public int Rating { get; set; }

        public string Gender { get; set; }

        public string ListWithWorks { get; set; }

        public string URL_Image { get; set; }
    }
}