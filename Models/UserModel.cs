using System.ComponentModel.DataAnnotations;
namespace Studentmanagementsystem.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public virtual StudentModel? Student { get; set; }
    }
}
