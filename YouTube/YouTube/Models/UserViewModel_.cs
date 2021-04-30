using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YouTube.Entity;

namespace YouTube.Models
{
    public class UserViewModel_
    {
        public int Id { get; set; }
        public string ChannelName { get; set; }
        public string ProfilePhoto { get; set; }
        public string MainPhoto { get; set; }
        public string ChannelDescription { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}
