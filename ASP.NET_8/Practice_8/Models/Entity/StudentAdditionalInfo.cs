using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Practice_8.Models.Entity
{
    [Table("tblStudentAdditionalInfo")]
    public class StudentAdditionalInfo
    {
        [Key]
        [ForeignKey("ApplicationStudent")]
        public string ID { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Group { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}