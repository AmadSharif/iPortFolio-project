using System.ComponentModel.DataAnnotations.Schema;

namespace iPortfolio.Model
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string theTestimonial { get; set; }
        public string? Image { get; set; }

        [NotMapped]
        public IFormFile? Photo{ get; set; }
    }
}
