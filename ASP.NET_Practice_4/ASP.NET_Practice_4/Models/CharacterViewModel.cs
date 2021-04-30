using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Practice_4.Models
{
    public class CharacterViewModel
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string BirthDate { get; set; }
        public int Rating { get; set; }
        public string Gender { get; set; }
        public List<SelectListItem> Genders { get; set; }
        public string URL_Image { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}