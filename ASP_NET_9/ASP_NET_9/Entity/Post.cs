﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP_NET_9.Entity
{
    [Table("tblPosts")]
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string DateRelease { get; set; }

        [Required]
        public string Author { get; set; }
    }
}