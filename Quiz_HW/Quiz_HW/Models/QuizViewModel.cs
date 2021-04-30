using Quiz_HW.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz_HW.Models
{
    public class QuizViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Question> Questions { get; set; }

        public void AddQuest(Question q)
        {
            Questions.Add(q);
        }
    }


}