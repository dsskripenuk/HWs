using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET_12_Practice.Entity
{
    [Table("tblListEvents")]
    public class ListEvents
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Event { get; set; }

        [Required]
        public string Time { get; set; }

        [Required]
        public string Date { get; set; }
    }
}