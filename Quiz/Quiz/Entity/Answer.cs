using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Quiz.Entity
{
    [Table("tblAnswer")]
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TextAnswer { get; set; }

        [Required]
        public bool isTrue { get; set; }

    }
}