using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP_NET_10.Models.Entity
{
    [Table("tblUserAdditionalInfo")]
    public class UserAdditonalInfo
    {
        [Key]
        [ForeignKey("ApplicationUser")]
        public string ID { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Address { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}