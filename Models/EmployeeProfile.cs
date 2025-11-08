
namespace BrushAndCanvas.Api.Models;

public class EmployeeProfiles
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public bool Enabled { get; set; } = true;

    public int UserId { get; set; }
    public Users? User { get; set; } = null;
}
