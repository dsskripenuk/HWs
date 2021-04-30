using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_12.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
    }
}