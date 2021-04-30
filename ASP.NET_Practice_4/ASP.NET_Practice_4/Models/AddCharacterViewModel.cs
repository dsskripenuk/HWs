using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Practice_4.Models
{
    public class AddCharacterViewModel
    {
        [Required(ErrorMessage = "Important!")]
        [StringLength(maximumLength: 100)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Important!")]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string BirthDate { get; set; }

        [Required(ErrorMessage = "Important!")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Important!")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Important!")]
        public List<SelectListItem> Genders { get; set; }

        [Required(ErrorMessage = "Important!")]
        [DisplayName("Image file:")]
        public HttpPostedFileBase URL_Image { get; set; }
    }
}