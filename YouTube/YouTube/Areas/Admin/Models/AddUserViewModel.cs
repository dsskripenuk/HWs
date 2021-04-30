using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using YouTube.Entity;

namespace YouTube.Areas.Admin.Models
{
    public class AddUserViewModel
    {
        [Required]
        public string ChannelName { get; set; }

        [Required]
        public string ProfilePhoto { get; set; }

        [Required]
        public string MainPhoto { get; set; }

        [Required]
        public string ChannelDescription { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}
