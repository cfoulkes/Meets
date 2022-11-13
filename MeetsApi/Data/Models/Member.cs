namespace MeetsApi.Data.Models;

public class Member
{
    private Member()
    {
    }

    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public virtual List<Meeting>? Meetings { get; set; }
    public virtual List<Meeting>? Attending { get; set; }

    public static Member Create(
        string firstName,
        string lastName,
        string email
    )
    {
        return new Member {
            FirstName = firstName,
            LastName = lastName,
            Email = email
        };
    }
}
