using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_6.Models
{
    public class CreateGameViewModel
    {
        [Required]
        [DisplayName("Name: ")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Price: ")]
        public float Price { get; set; }

        [Required]
        [DisplayName("Developer: ")]
        public string Developer { get; set; }

        [Required]
        [DisplayName("Image file: ")]
        public HttpPostedFileBase ImageFile { get; set; }

    }
}