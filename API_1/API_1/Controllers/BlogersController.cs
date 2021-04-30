using API_1.Entity;
using API_1.Models;
using API_1.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_1.Controllers
{
    [RoutePrefix("api/bloggers")]
    public class BlogersController : ApiController
    {
        private EFContext _context;

        public BlogersController()
        {
            _context = new EFContext();
        }

        [HttpGet]
        [Route("getCategories")]
        public List<CategoryDTO> GetCategory()
        {
            var data = _context.categories.Select(t => new CategoryDTO
            {
                Id = t.Id,
                Name = t.Name,
            }).ToList();

            return data;
        }

        [HttpGet]
        [Route("getBloggers")]
        public List<BloggerDTO> GetBloggers()
        {
            var data = _context.bloggers.Select(t => new BloggerDTO
            {
                AudienceAge = t.AudienceAge,
                CategoryId = t.CategoryId,
                Subscribers = t.Subscribers,
                Description = t.Description,
                Id = t.Id,
                Image = t.Image,
                Name = t.Name,
                Platform = t.Platform
            }).ToList();

            return data;
        }

        [HttpGet]
        [Route("getShortBloggers")]
        public List<ShortBloggersDTO> GetShortBloggers()
        {
            var data = _context.bloggers.Select(t => new ShortBloggersDTO
            {
                Subscribers = t.Subscribers,
                Id = t.Id,
                Image = t.Image,
                Name = t.Name
            }).ToList();

            return data;
        }

        [HttpPost]
        [Route("PostBlogger")]
        public ResultDTO Create([FromBody] CreateBloggerDTO dto)
        {
            try
            {
                _context.bloggers.Add(new Blogger()
                {
                    AudienceAge = dto.AudienceAge,
                    CategoryId = dto.CategoryId,
                    Subscribers = dto.Subscribers,
                    Description = dto.Description,
                    Image = dto.Image,
                    Name = dto.Name,
                    Platform = dto.Platform
                });

                _context.SaveChanges();

                return new ResultDTO
                {
                    Code = 200,
                    Message = "OK!"
                };
            }
            catch (Exception e)
            {
                return new ResultDTO
                {
                    Code = 500,
                    Message = e.Message
                };
                throw;
            }


        }
    }
}
