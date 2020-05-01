using System;
using System.Linq;
using System.Collections.Generic;
using social_media.CORE.Entities;
using social_media.CORE.Interfaces;
using System.Threading.Tasks;
using social_media.INFRASTRUCTURE.Data;
using Microsoft.EntityFrameworkCore;

namespace social_media.INFRASTRUCTURE.Repositories
{
    public class PostRepository : IPostRepository
    {
        public SocialMediaContext SocialMediaContext { get; set; }
        public PostRepository(SocialMediaContext socialMediaContext)
        {
            this.SocialMediaContext = socialMediaContext;
        }
        async Task<IEnumerable<Publicacion>> IPostRepository.GetPosts() => await SocialMediaContext.Publicacion.ToListAsync();
    }
}