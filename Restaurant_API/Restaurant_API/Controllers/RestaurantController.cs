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
    public class RestaurantController : ControllerBase
    {
        private readonly EFContext _context;

        public RestaurantController(EFContext context)
        {
            _context = context;
        }

        [HttpGet("getCategories")]
        public List<CategoryDTO> GetNews()
        {
            var data = _context.Categories.Select(t => new CategoryDTO
            {
                Id = t.Id,
                Title = t.Title
            }).ToList();

            return data;
        }

        [HttpPost("addCategories")]
        public ResultDTO AddNews([FromBody] CreateCategoryDTO t)
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

                _context.Categories.Add(new Category
                {
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
    }
}
