using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_4.Models
{
    public class GameViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string URL_Image { get; set; }
    }
}