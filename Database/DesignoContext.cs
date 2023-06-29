using Designo.Website.Models;
using Microsoft.EntityFrameworkCore;

namespace Designo.Website.Database;
public class DesignoContext: DbContext
{
    public DesignoContext(DbContextOptions<DesignoContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DesignCategory>().HasIndex(d => d.Name).IsUnique();
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<CoreValue> CoreValues { get; set; }

    public DbSet<Design> Designs { get; set; }

    public DbSet<DesignCategory> DesignCategories { get; set; }
}
