using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API_1.Entity
{
    [Table("tblBloggers")]
    public class Blogger
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Subscribers { get; set; }

        [Required]
        public string Platform { get; set; }

        [Required]
        public int AudienceAge { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }
    }
}