using System.ComponentModel.DataAnnotations;

namespace social_media.API.Models
{
    public class Ailment
    {
        [Key]
        public string Name { get; set; }
    }
}