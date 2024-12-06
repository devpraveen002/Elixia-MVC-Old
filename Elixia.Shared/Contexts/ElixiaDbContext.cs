using Elixia.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Elixia.Shared.Contexts;

public class ElixiaDbContext : DbContext
{
    public ElixiaDbContext()
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }
    public ElixiaDbContext(DbContextOptions<ElixiaDbContext> options) : base(options)
    {

    }
    public DbSet<User> Users { get; set; }
    public DbSet <Address> Addresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=local_elixia_db;Username= local_elixia_user_devpk;Password=LSUser12"); // Example for PostgreSQL
        }
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}
