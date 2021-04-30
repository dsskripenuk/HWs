using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_Practice_8.Models
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string Image_Url { get; set; }
        public string Description { get; set; }
        public List<SelectListItem> Group { get; set; }
        public string DateOfBirth { get; set; }
    }

    public class AddUserViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Image_Url { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        public List<SelectListItem> Group { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }
    }
}