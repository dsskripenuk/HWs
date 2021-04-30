using First_Core_API.DTO;
using First_Core_API.DTO.Result;
using First_Core_API.Entity;
using First_Core_API.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace First_Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly EFContext _context;

        public NewsController(EFContext context)
        {
            _context = context;
        }

        [HttpGet("getNews")]
        public List<NewsDTO> GetNews()
        {
            var data = _context.News.Select(t => new NewsDTO
            {
                Author = t.Author,
                DateRelease = t.DateRelease,
                Description = t.Description,
                Id = t.Id,
                Title = t.Title
            }).ToList();

            return data;
        }

        [HttpPost("addNews")]
        public ResultDTO AddNews([FromBody] CreateNewsDTO t)
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

                if (t.Rating >= 0 && t.Rating <= 5)
                    _context.News.Add(new News
                    {
                        Author = t.Author,
                        DateRelease = t.DateRelease,
                        Description = t.Description,
                        Rating = t.Rating,
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

        [HttpPost("sort")]
        public List<News> SortNews()
        {
            var items = _context.News.OrderBy(x => x.Rating).ToList();

            return items;
        }


        [HttpPut("EditNews/{idNews}")]
        public ResultDTO EditNews([FromRoute] int idNews, [FromBody] CreateNewsDTO dto)
        {
            try
            {
                var current_news = _context.News.FirstOrDefault(t => t.Id == idNews);

                current_news.Title = dto.Title;
                current_news.Description = dto.Description;
                current_news.Author = dto.Author;
                current_news.DateRelease = dto.DateRelease;

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

        [HttpGet("removeNews/{idNews}")]
        public ResultDTO RemoveNews([FromRoute] int idNews)
        {
            try
            {
                var removeNews = _context.News.FirstOrDefault(t => t.Id == idNews);
                _context.News.Remove(removeNews);
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
        public List<NewsDTO> Search([FromQuery] string q)
        {
            var data = _context.News.Where(t => t.Title.Contains(q)).Select(t => new NewsDTO
            {
                Title = t.Title,
                Author = t.Author,
                DateRelease = t.DateRelease,
                Description = t.Description,
                Id = t.Id
            }).ToList();

            return data;
        }
    }
}
