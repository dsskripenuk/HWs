using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace University_HW.Entity
{
    [Table("tblStudents")]
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Image_Url { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        public string St_Group { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }
    }
}