using Microsoft.EntityFrameworkCore;

namespace BrushAndCanvas.Api.Models;

[Index(nameof(Email), IsUnique = true)]
public class Users
{
    public int Id { get; set; }

    public string Email { get; set; } = string.Empty;

    public byte[] PasswordHash { get; set; } = new byte[0];
    public byte[] PasswordSalt { get; set; } = new byte[0];

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
