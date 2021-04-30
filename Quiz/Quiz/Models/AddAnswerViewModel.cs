using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class AddAnswerViewModel
    {
        [Required(ErrorMessage = "Important!")]
        public string TextAnswer { get; set; }

        [Required(ErrorMessage = "Important!")]
        public bool isTrue { get; set; }

        [Required(ErrorMessage = "Important!")]
        public int QuestionId { get; set; }
    }
}