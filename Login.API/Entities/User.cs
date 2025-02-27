using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Login.API.Entities;

public class User
{
    [Key]
    public int IdUser { get; set; }

    [Required]
    [MaxLength(256)]
    public required string Email { get; set; }

    [Required]
    [MaxLength(100)]
    public required string Password { get; set; }

    public User()
    {
        
    }

    [SetsRequiredMembers]
    public User(int idUser, string email, string password)
    {
        IdUser = idUser;
        Email = email;
        Password = password;
    }
}
