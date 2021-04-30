using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace University.Entity
{
    [Table("tblGroups")]
    public class Group_St
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime Start { get; set; }
    }
}