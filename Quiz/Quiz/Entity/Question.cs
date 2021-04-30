using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Quiz.Entity
{
    [Table("tblQuestion")]
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TextQuestion { get; set; }

        [Required]
        
        public string asnw1 { get; set; }

        [Required]
        public string asnw2 { get; set; }

        [Required]
        public string asnw3 { get; set; }

        [Required]
        public string asnw4 { get; set; }

        public List<Answer> answers { get; set; }
    }
}
