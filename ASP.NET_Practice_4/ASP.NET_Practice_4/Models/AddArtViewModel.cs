using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_Practice_4.Models
{
    public class AddArtViewModel
    {
        [Required(ErrorMessage = "Important!")]
        [StringLength(maximumLength: 500)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Important!")]
        [DisplayName("Image file:")]
        public HttpPostedFileBase URL_Image { get; set; }
    }
}