using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant_API.DTO;
using Restaurant_API.DTO.Result;
using Restaurant_API.Entity;
using Restaurant_API.Helper;

namespace Restaurant_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly EFContext _context;

        public CategoryController(EFContext context)
        {
            _context = context;
        }

        [HttpGet("getDishes")]
        public List<RestaurantDTO> GetNews()
        {
            var data = _context.Restaurants.Select(t => new RestaurantDTO
            {
                CategoryId = t.CategoryId,
                Composition = t.Composition,
                Description = t.Description,
                Id = t.Id,
                Title = t.Title
            }).ToList();

            return data;
        }

        [HttpPost("addDishes")]
        public ResultDTO AddNews([FromBody] CreateRestaurantDTO t)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return new ResultErrorDTO
                    {
                        Code = 400,
                        Message = "Invalid data",
                        Error = CustomValidator.getErrorsByModel(ModelState)
                    };
                }

                _context.Restaurants.Add(new Restaurant
                {
                    CategoryId = t.CategoryId,
                    Composition = t.Composition,
                    Description = t.Description,
                    Title = t.Title
                });
                _context.SaveChanges();

                return new ResultDTO
                {
                    Code = 200,
                    Message = "OK"
                };
            }
            catch (Exception e)
            {
                return new ResultDTO
                {
                    Code = 500,
                    Message = e.Message
                };
            }
        }

        [HttpPut("EditDishes/{idNews}")]
        public ResultDTO EditNews([FromRoute] int idNews, [FromBody] CreateRestaurantDTO dto)
        {
            try
            {
                var current_resturaunt = _context.Restaurants.FirstOrDefault(t => t.Id == idNews);

                current_resturaunt.Title = dto.Title;
                current_resturaunt.Description = dto.Description;
                current_resturaunt.Composition = dto.Composition;
                current_resturaunt.CategoryId = dto.CategoryId;

                _context.SaveChanges();

                return new ResultDTO
                {
                    Code = 200,
                    Message = "OK"
                };
            }
            catch (Exception e)
            {
                return new ResultDTO
                {
                    Code = 500,
                    Message = e.Message
                };
            }
        }

        [HttpGet("removeDishes/{idNews}")]
        public ResultDTO RemoveNews([FromRoute] int idNews)
        {
            try
            {
                var removeNews = _context.Restaurants.FirstOrDefault(t => t.Id == idNews);
                _context.Restaurants.Remove(removeNews);
                _context.SaveChanges();

                return new ResultDTO
                {
                    Code = 200,
                    Message = "OK"
                };
            }
            catch (Exception e)
            {
                return new ResultDTO
                {
                    Code = 500,
                    Message = e.Message
                };
            }
        }

        [HttpGet("search")]
        public List<RestaurantDTO> Search([FromQuery] string q)
        {
            var data = _context.Restaurants.Where(t => t.Title.Contains(q)).Select(t => new RestaurantDTO
            {
                CategoryId = t.CategoryId,
                Composition = t.Composition,
                Description = t.Description,
                Id = t.Id,
                Title = t.Title
            }).ToList();

            return data;
        }
    }
}
