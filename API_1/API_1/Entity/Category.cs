using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API_1.Entity
{
    [Table("tblCategory")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}