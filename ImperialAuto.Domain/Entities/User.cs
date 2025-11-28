using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialAuto.Domain.Entities
{
    public enum UserRole
    {
        User,
        Admin
    }
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }

        public UserRole Role { get; set; } = UserRole.User;
    }
}
