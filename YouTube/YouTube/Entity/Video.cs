﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YouTube.Entity
{
    [Table("tblVideos")]
    public class Video
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Img { get; set; }

        [Required]
        public int UserId { get; set; }
        public User_ user { get; set; }
    }
}
