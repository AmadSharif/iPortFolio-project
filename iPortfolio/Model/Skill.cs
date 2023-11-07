using System.ComponentModel.DataAnnotations;

namespace iPortfolio.Model
{
    public class Skill
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Percentage %")]

        public int Percentage { get; set; }
    }
}
