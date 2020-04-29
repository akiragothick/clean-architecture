using System;
using System.Linq;
using System.Collections.Generic;
using social_media.CORE.Entities;

namespace social_media.INFRASTRUCTURE.Repositories
{
    public class PostRepository
    {
        public IEnumerable<Post> GetPosts()
         => Enumerable.Range(1, 10).Select(x => new Post()
         {
             PostId = x,
             Description = $"Description {x}",
             Date = DateTime.Now,
             Image = $"https://misimages.com/{x}",
             UserId = x * 2
         });
    }
}