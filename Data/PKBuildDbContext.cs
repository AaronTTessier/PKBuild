using Microsoft.EntityFrameworkCore;
using PKBuild.Configurations;
using PKBuild.Models;

namespace PKBuild.Data;

public class PKBuildDbContext : DbContext
{
    
    public DbSet<PokemonPageModel> Pokemon => Set<PokemonPageModel>();
    public DbSet<UserPageModel> Users => Set<UserPageModel>();
    public DbSet<BaseStatsPageModel> BaseStats => Set<BaseStatsPageModel>();
    public DbSet<TeamsPageModel> Teams => Set<TeamsPageModel>();
    
    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=PKBuild.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}