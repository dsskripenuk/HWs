using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp_Net_Anime.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CreateCategoryViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}