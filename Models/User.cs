using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMDBNetWeb.Models

{
    [Table("User")] 
    public partial class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
