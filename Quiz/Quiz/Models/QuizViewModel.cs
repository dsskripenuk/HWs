using Quiz.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class QuizViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}