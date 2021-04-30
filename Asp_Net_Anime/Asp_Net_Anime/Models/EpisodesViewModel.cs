using Asp_Net_Anime.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp_Net_Anime.Models
{
    public class EpisodesViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Season { get; set; }

        [Required]
        public string Img_URL { get; set; }

        [Required]
        public string Video_URL { get; set; }

        [Required]
        public int AnimeId { get; set; }
        public Anime anime { get; set; }
    }

    public class AddEpisodesViewModel
    {
        [Required]
        public int Season { get; set; }

        [Required]
        public string Img_URL { get; set; }

        [Required]
        public string Video_URL { get; set; }

        [Required]
        public int AnimeId { get; set; }
        public Anime anime { get; set; }
    }
}