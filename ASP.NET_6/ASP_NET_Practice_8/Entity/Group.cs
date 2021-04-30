using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_NET_Practice_8.Entity
{
    public class Group
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
    }
}