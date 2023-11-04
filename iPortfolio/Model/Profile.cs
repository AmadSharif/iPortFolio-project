using System.ComponentModel.DataAnnotations.Schema;

namespace iPortfolio.Model
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public int Age { get; set; }
        public string Website { get; set; }
        public string Degree { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public string City { get; set; }
        public string FreelanceStatus { get; set; }
        public string DescOne { get; set; }
        public string DescTwo { get; set; }
        public string? Image { get; set; }

        [NotMapped]
        public IFormFile? Photo { get; set; }
    }
}
