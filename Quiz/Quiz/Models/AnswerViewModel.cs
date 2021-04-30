using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class AnswerViewModel
    {
        public int Id { get; set; }
        public string TextAnswer { get; set; }
        public bool isTrue { get; set; }
        public int QuesttionId { get; set; }
    }
}