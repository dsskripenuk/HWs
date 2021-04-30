using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace University.Areas.Admin.Models
{
    public class AddGroupViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime Start { get; set; }
    }
}