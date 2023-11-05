using System.ComponentModel.DataAnnotations;

namespace iPortfolio.Model
{
    public class Education
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Degree")]
        public string Degree { get; set; }
        [Required(ErrorMessage = "Please Enter Start Year")]
        public string StartYear { get; set; }
        [Required(ErrorMessage = "Please Enter End Year")]
        public string EndYear { get; set; }
        [Required(ErrorMessage = "Please Enter Institute Name")]
        public string InstituteName { get; set; }
        [Required(ErrorMessage = "Please Enter Description")]
        public string Desc { get; set; }
    }
}
