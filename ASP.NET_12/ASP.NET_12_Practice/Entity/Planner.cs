using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET_12_Practice.Entity
{
    [Table("tblPlanner")]
    public class Planner
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public string Image { get; set; }
    }
}