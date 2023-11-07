using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iPortfolio.Model
{
    public class Testimonial
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please Enter Designation")]
        public string Designation { get; set; }


        [Required(ErrorMessage = "Please Enter Testimonial")]
        public string theTestimonial { get; set; }


        public string? Image { get; set; }

        [NotMapped]
        public IFormFile? Photo{ get; set; }
    }
}
