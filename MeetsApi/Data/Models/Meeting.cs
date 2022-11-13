namespace MeetsApi.Data.Models;

public class Meeting
{
    public int Id { get; set; }
    public MeetingType Type { get; set; } = null!;
    public DateTime ScheduledAtUtc { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Location { get; set; } = string.Empty;

    //Foreign keys
    public int CreatorId { get; set; }
    public Member Creator { get; set; } = null!;

    
    public virtual List<Invitation>? Invitations { get; set; }
    public virtual List<Member>? Attendees { get; set; }
}
