namespace MeetsApi.Data.Models;

public class Meeting
{
    public int Id { get; set; }
    public int Type { get; set; }
    public DateTime ScheduledAtUtc { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Location { get; set; } = string.Empty;

    //Foreign keys
    public int CreatorId { get; set; }
    public Member Creator { get; set; } = null!;

}
