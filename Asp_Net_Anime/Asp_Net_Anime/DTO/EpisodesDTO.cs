using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp_Net_Anime.DTO
{
    public class EpisodesDTO
    {
        public int Id { get; set; }
        public int Season { get; set; }
        public string Img_URL { get; set; }
        public string Video_URL { get; set; }
        public int AnimeId { get; set; }
    }
}