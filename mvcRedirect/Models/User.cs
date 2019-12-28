using System.ComponentModel.DataAnnotations;
namespace mvcRedirect.Models
{
    public class User
    {
        [Display(Name = "username")]
        [Required(ErrorMessage = "Ya abolfazl {0}")]
        public string username { get; set; }
        [Display(Name = "password")]
        [Required(ErrorMessage = "Ya abolfazl {0}")]
        public string password { get; set; }
        public bool remember { get; set; }
    }
}