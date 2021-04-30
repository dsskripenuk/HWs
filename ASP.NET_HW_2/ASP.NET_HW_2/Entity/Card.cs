using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET_HW_2.Entity
{
    [Table("tblCard")]
    public class Card
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public string FullDescription { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        [Required]
        public string Img { get; set; }
    }
}