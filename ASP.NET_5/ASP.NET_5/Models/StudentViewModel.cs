using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_5.Models
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public int studentGender { get; set; }
        public List<SelectListItem> Genders { get; set; }

        //public int Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}