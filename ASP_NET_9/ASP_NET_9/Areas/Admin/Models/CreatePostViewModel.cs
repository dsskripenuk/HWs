using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_NET_9.Areas.Admin.Models
{
    public class CreatePostViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string DateRelease { get; set; }

        [Required]
        public string Author { get; set; }
    }
}