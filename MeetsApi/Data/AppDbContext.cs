using MeetsApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetsApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Meeting> Meetings { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Attendee> Attendees { get; set; }
    public DbSet<Invitation> Invitations { get; set; }
    public DbSet<InvitationStatus> InvitationStatuses { get; set; }
    public DbSet<MeetingType> MeetingTypes { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attendee>()
            .HasKey(a => new { a.MemberId, a.MeetingId });

        modelBuilder.Entity<Meeting>()
            .HasOne(m => m.Creator)
            .WithMany(m => m.Meetings);

        modelBuilder.Entity<Member>()
        .HasMany(m => m.Attending)
        .WithMany(m => m.Attendees)
        .UsingEntity<Attendee>();
    }
}

