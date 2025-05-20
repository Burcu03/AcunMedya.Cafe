using System.ComponentModel.DataAnnotations;

namespace AcunMedya.Coffe.Entities
{
    public class About
    {
        public int AboutId { get; set; }

        [MaxLength(200)]
        public string SubTitle { get; set; }

        [MaxLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
    }
}
