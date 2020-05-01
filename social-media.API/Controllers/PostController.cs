using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using social_media.CORE.Interfaces;
using social_media.INFRASTRUCTURE.Repositories;

namespace social_media.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        public IPostRepository PostRepository { get; set; }
        public PostController(IPostRepository postRepository)
        {
            this.PostRepository = postRepository;
        }


        [HttpGet] //api/post
        public async Task<IActionResult> GetPosts()
        {
            var posts = await PostRepository.GetPosts();

            return Ok(posts);
        }
    }
}