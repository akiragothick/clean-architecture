using System.Collections.Generic;
using System.Threading.Tasks;
using social_media.CORE.Entities;

namespace social_media.CORE.Interfaces
{
    public interface IPostRepository
    {
         Task<IEnumerable<Publicacion>> GetPosts();
    }
}