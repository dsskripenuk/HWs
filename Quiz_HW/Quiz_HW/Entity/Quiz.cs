using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Quiz_HW.Entity
{
    [Table("tblQuiz")]
    public class Quiz
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Question> Questions { get; set; }

        public void AddQuest(Question q)
        {
            Questions.Add(q);
        }
    }


}