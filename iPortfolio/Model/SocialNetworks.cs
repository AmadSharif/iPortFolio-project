using System.ComponentModel.DataAnnotations;

namespace iPortfolio.Model
{
    public class SocialNetworks
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Facebook Login ID")]
        public string Facebook { get; set; }
        [Required(ErrorMessage = "Please Enter Twitter Login ID")]
        
        public string Twitter { get; set; }
        [Required(ErrorMessage = "Please Enter LinkedIn Login ID")]
   
        public string LinkedIn { get; set; }
        [Required(ErrorMessage = "Please Enter Instagram Login ID")]
        public string Instagram { get; set; }
        [Required(ErrorMessage = "Please Enter Skype Login ID")]
        public string Skype { get; set; }
    }
}
