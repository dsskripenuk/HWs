using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using YouTube.Entity;

namespace YouTube.Models
{
    public class AddVideoViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Img { get; set; }

        [Required]
        public int UserId { get; set; }
        public User_ user { get; set; }
    }
}
