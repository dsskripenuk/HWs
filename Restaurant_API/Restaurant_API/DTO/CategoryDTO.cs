using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class CreateCategoryDTO
    {
        [Required(ErrorMessage = "Title is required field")]
        public string Title { get; set; }
    }
}
