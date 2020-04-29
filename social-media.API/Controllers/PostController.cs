using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using social_media.INFRASTRUCTURE.Repositories;

namespace social_media.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPosts()
        {
            var posts = new PostRepository().GetPosts();
            return Ok(posts);
        }
    }
}