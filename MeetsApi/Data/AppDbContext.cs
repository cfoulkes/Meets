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
}

