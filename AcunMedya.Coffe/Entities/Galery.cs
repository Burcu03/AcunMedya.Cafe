using System.ComponentModel.DataAnnotations;

namespace AcunMedya.Coffe.Entities
{
    public class Galery
    {
        public int GaleryId { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        [MaxLength(200)]
        public string Title { get; set; }
    }
}
