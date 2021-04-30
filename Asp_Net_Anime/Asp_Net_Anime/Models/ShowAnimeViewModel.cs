using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp_Net_Anime.Models
{
    public class ShowAnimeViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ReleaseDate { get; set; }
        public string CategoryName { get; set; }
    }
}