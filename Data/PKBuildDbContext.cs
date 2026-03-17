using Microsoft.EntityFrameworkCore;
using PKBuild.Models;

namespace PKBuild.Data;

public class PKBuildDbContext : DbContext
{
    
    public DbSet<PokemonPageModel> Pokemon { get; set; }
    public DbSet<UserPageModel> Users { get; set; }
    public DbSet<BaseStatsPageModel> BaseStats { get; set; }
    public DbSet<PkmnTeamsJointPageModel> PkmnTeams { get; set; }
    public DbSet<TeamsPageModel> Teams { get; set; }
    
    // TODO: Teams Table
    
    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=PKBuild.db");
    }
}