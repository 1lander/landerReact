using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using landerReact.Models;
using Microsoft.AspNetCore.Mvc;

namespace landerReact.Controllers
{
    [Route("api/[Controller]")]
    
    public class TextPostController : Controller
    {
        public TextPostContext _context { get; set; }
        public TextPostController(TextPostContext c)
        {
            _context = c;
        }

        [HttpGet]
        public List<TextPost> GetPosts()
        {
            return _context.TextPost.ToList();
        }

        [HttpPost]
        public ActionResult<TextPost> AddPost([FromBody]TextPost post)
        {
            _context.TextPost.Add(post);
            _context.SaveChanges();
            return Created("", post);
        }

        [HttpPut]
        public ActionResult<TextPost> UpdatePost([FromBody]TextPost post)
        {
            _context.TextPost.Update(post);
            _context.SaveChanges();
            return Created("", post);
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult DeletePost(int id)
        {
            var post = _context.TextPost.Find(id);
            if (post == null)
                return NotFound();

            _context.TextPost.Remove(post);
            _context.SaveChanges();
            return NoContent();
        }
    }
}