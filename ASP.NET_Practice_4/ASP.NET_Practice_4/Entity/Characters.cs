using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Practice_4.Entity
{
    [Table("tblCharacters")]
    public class Character
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string BirthDate { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string URL_Image { get; set; }
    }
}
