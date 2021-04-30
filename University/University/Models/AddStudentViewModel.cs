using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace University.Models
{
    public class AddStudentViewModel
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

        [Required]
        public string Email { get; set; }
    }
}