using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET_3.Entity
{
    [Table("tblStudent")]
    public class Actor
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
        public string ListWithWorks { get; set; }

        [Required]
        public string URL_Image { get; set; }
    }
}