using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.DTO
{
    public class RestaurantDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Composition { get; set; }
        public int CategoryId { get; set; }
    }

    public class CreateRestaurantDTO
    {
        [Required(ErrorMessage = "Title is required field")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required field")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Composition is required field")]
        public string Composition { get; set; }

        [Required(ErrorMessage = "CategoryId is required field")]
        public int CategoryId { get; set; }
    }
}
