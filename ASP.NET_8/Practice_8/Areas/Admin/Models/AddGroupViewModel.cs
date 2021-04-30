using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practice_8.Areas.Admin.Models
{
    public class AddGroupViewModel
    {
        [Required]
        public string Title { get; set; }
    }
}
