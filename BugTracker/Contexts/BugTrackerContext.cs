using BugTracker.Entities;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Contexts;

public class BugTrackerContext : DbContext
{
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<RoleHasPermission> Role_Has_Permission { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<ProjectHasUsers> Project_Has_Users { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<TicketHistory> TicketHistory { get; set; }

    public BugTrackerContext(DbContextOptions<BugTrackerContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Specify that NoPrimaryKeyEntity should have no primary key
        modelBuilder.Entity<ProjectHasUsers>().HasNoKey();
        modelBuilder.Entity<RoleHasPermission>().HasNoKey();
    }
}
