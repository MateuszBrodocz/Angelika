using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codecool.OnlineStore.Models
{
    /// <summary>
    /// User class
    /// </summary>

    [Table("User")]
    public class User
    {
        /// <summary>
        /// Gets or sets user's id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets user's username
        /// </summary>

        [StringLength(50)]
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets user's password
        /// </summary>

        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets user's role
        /// </summary>

        [Required]
        public UserRole Role { get; set; }

        public User()
        {
        }

        public User(string username, string password, UserRole role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }
}
