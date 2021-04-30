using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_1.Models
{
    public class BloggerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Subscribers { get; set; }
        public string Platform { get; set; }
        public int AudienceAge { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }

    public class ShortBloggersDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Subscribers { get; set; }
        public string Image { get; set; }
    }

    public class CreateBloggerDTO
    {
        public string Name { get; set; }
        public int Subscribers { get; set; }
        public string Platform { get; set; }
        public int AudienceAge { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }

    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
