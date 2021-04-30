using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using University_Manager_HW.Models;

namespace University_Manager_HW.Entity
{
    [Table("tblStudentGroup")]
    public class StudentGroup
    {
        [Key]
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public int GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}