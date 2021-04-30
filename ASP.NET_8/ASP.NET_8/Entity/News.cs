using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET_8.Entity
{
    [Table("tblNews")]
    public class News
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Image_Url { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string ReleaseDate { get; set; }
    }
}