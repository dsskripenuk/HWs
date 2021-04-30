using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YouTube.Areas.Admin.Models
{
    public class AddCategoryViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}
