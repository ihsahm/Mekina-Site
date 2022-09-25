using System.ComponentModel.DataAnnotations;

namespace MekinaWebsite.Models
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        public string Email { set; get; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { set; get; }
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
