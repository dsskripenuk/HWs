using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YouTube.Entity
{
    [Table("tblUsers")]
    public class User_
    {
        [Key]
        public int Id { get; set; }

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
