using MeetsApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetsApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Member> Members => Set<Member>();
    public DbSet<Meeting> Meetings => Set<Meeting>();
    public DbSet<Attendee> Attendees => Set<Attendee>();
    public DbSet<Invitation> Invitationa => Set<Invitation>();
    public DbSet<InvitationStatus> InvitationStatuss => Set<InvitationStatus>();
    public DbSet<MeetingType> MeetingTypes => Set<MeetingType>();

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

