using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz_HW.Models
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public string TextQuestion { get; set; }
        public string asnw1 { get; set; }
        public string asnw2 { get; set; }
        public string asnw3 { get; set; }
        public string asnw4 { get; set; }
    }
}