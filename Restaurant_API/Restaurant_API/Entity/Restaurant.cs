﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Entity
{
    [Table("Restaurant")]
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Composition { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
