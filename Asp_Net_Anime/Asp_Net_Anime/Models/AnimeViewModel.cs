using Asp_Net_Anime.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Asp_Net_Anime.Models
{
    public class AnimeViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Episodes> Episodes { get; set; }
        public string Image { get; set; }
        public ICollection<Screenshots> Screenshots { get; set; }
        public string ReleaseDate { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }
    }

    public class CreateAnimeViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string ReleaseDate { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category category { get; set; }
        public ICollection<Episodes> Episodes { get; set; }
        public ICollection<Screenshots> Screenshots { get; set; }
    }
}
