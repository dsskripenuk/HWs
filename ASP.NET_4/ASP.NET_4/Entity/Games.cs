﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET_4.Entity
{
    [Table("tblGames")]
    public class Games
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Developer { get; set; }

        [Required]
        public string Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string URL_Image { get; set; }
    }
}