﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Asp_Net_Anime.Entity
{
    [Table("tblEpisodes")]
    public class Episodes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Season { get; set; }

        [Required]
        public string Img_URL { get; set; }

        [Required]
        public string Video_URL { get; set; }

        public int AnimeId { get; set; }
        public Anime anime { get; set; }
    }
}