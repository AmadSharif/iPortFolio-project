using System.ComponentModel.DataAnnotations;

namespace iPortfolio.Model
{
    public class Facts
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Clients")]
        public int Clients { get; set; }
        [Required(ErrorMessage = "Please Enter Projects")]
        public int Projects { get; set; }
        [Required(ErrorMessage = "Please Enter Hours")]
        public int Hours { get; set;}
        [Required(ErrorMessage = "Please Enter HardWorkers")]
        public int HardWorkers { get; set;}
    }
}
