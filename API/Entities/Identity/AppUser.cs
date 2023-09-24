using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace API.Entities.Identity
{
    public class AppUser : IdentityUser
    {
        [Key]
        public int Id { get; set; }
        public string DisplayName { get; set; }
    }
} 