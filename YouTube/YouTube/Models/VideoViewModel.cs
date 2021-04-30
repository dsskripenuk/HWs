using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YouTube.Entity;

namespace YouTube.Models
{
    public class VideoViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public int UserId { get; set; }
        public User_ user { get; set; }
    }
}
