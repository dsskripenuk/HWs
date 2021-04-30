using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quiz_HW.Models
{
    public class AddQuestionViewModel
    {
        [Required(ErrorMessage = "Important!")]
        public string TextQuestion { get; set; }

        [Required(ErrorMessage = "Important!")]
        public int QuizId { get; set; }

        [Required(ErrorMessage = "Important!")]
        public string asnw1 { get; set; }

        [Required(ErrorMessage = "Important!")]
        public string asnw2 { get; set; }

        [Required(ErrorMessage = "Important!")]
        public string asnw3 { get; set; }

        [Required(ErrorMessage = "Important!")]
        public string asnw4 { get; set; }
    }
}