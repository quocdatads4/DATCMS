using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DATCMS.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
    }
}
