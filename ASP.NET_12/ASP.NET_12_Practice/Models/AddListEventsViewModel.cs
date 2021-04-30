using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_12_Practice.Models
{
    public class AddListEventsViewModel
    {
        [Required(ErrorMessage = "Important!")]
        public string Event { get; set; }

        [Required(ErrorMessage = "Important!")]
        public string Time { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string Date { get; set; }
    }
}