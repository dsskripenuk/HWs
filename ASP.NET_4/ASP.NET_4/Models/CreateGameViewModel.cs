using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_4.Models
{
    public class CreateGameViewModel
    { 
        [Required(ErrorMessage = "Important!")]
        [StringLength(maximumLength: 100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Important!")]
        [StringLength(maximumLength: 100)]
        public string Developer { get; set; }

        [Required(ErrorMessage = "Important!")]
        [Range(0, 100)]
        [DataType(DataType.Currency)]
        public string Price { get; set; }

        [Required(ErrorMessage = "Important!")]
        [StringLength(maximumLength: 500)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Important!")]
        public string URL_Image { get; set; }
    }
}