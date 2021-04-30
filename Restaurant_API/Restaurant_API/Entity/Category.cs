using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Entity
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }
    }
}
