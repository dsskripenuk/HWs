using Quiz.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class AddQuizViewModel
    {
        [Required(ErrorMessage = "Important!")]
        public string Name { get; set; }
        public ICollection<Question> Questions { get; set; }

    }
}