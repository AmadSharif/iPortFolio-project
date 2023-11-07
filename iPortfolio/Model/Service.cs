using System.ComponentModel.DataAnnotations;

namespace iPortfolio.Model
{
    public class Service
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Title")]
        public string Title  { get; set; }
        [Required(ErrorMessage = "Please Enter Description")]

        public string Desc { get; set; }
        [Required(ErrorMessage = "Please Enter Icon Name")]

        public string IconName { get; set; }
    }
}
