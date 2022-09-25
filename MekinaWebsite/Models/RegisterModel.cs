using System.ComponentModel.DataAnnotations;

namespace MekinaWebsite.Models
{
    public class RegisterModel
    {

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
