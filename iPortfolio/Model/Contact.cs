using System.ComponentModel.DataAnnotations;

namespace iPortfolio.Model
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please Enter Message")]
        public string Message { get; set; }
    }
}
