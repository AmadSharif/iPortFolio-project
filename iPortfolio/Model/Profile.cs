using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iPortfolio.Model
{
    public class Profile
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Please Enter your Birth Date")]
        public string Birthday { get; set; }
        [Required(ErrorMessage = "Please Enter Age")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please Enter Website")]

        public string Website { get; set; }
        [Required(ErrorMessage = "Please Enter Degree")]

        public string Degree { get; set; }
        [Phone(ErrorMessage = "Please Enter Phone")]

        public string Phone { get; set; }
        [EmailAddress(ErrorMessage = "Please Enter Email")]

        public string EMail { get; set; }
        [Required(ErrorMessage = "Please Enter City")]

        public string City { get; set; }
        [Required(ErrorMessage = "Please Enter Freelance Status")]

        public string FreelanceStatus { get; set; }
        [Required(ErrorMessage = "Please Enter Description One")]

        public string DescOne { get; set; }
        [Required(ErrorMessage = "Please Enter Description Two")]

        public string DescTwo { get; set; }

        public string? Image { get; set; }

        [NotMapped]
        public IFormFile? Photo { get; set; }





    }
}
