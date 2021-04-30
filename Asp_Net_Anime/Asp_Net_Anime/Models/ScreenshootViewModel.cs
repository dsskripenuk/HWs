using Asp_Net_Anime.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp_Net_Anime.Models
{
    public class ScreenshootViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public int AnimeId { get; set; }
        public Anime anime { get; set; }
    }

    public class AddScreenshootViewModel
    {
        public string Image { get; set; }

        public int AnimeId { get; set; }
        public Anime anime { get; set; }
    }

}