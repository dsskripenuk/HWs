using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp_Net_Anime.DTO
{
    public class ScreenshotDTO
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int AnimeId { get; set; }
    }
}