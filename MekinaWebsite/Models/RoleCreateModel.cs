using System.ComponentModel.DataAnnotations;

namespace MekinaWebsite.Models
{
    public class RoleCreateModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
