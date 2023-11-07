using System.ComponentModel.DataAnnotations;

namespace iPortfolio.Model
{
    public class Experiance
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Job Title")]
        public string JobTitle { get; set; }
        [Required(ErrorMessage = "Please Enter Start Year")]
        public string StartYear { get; set; }
        [Required(ErrorMessage = "Please Enter End Year")]
        public string EndYear { get; set; }
        [Required(ErrorMessage = "Please Enter Location")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Please Enter Description")]
        public string Desc { get; set; }
    }
}
