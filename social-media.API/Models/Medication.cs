using System.ComponentModel.DataAnnotations;

namespace social_media.API.Models
{
    public class Medication
    {
        [Key]
        public string Name { get; set; }
        public string Doses { get; set; }
    }
}