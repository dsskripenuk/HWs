using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP_NET_Practice_8.Entity
{
    [Table("tblUsers")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Image_Url { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        public string Group { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }
    }
}