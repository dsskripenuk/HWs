using Quiz_HW.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz_HW.Models
{
    public class AddQuizViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}