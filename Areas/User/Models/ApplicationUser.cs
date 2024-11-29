using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DATCMS.Areas.User.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
    }
}
