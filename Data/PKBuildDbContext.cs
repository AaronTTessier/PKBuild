using Microsoft.EntityFrameworkCore;
using PKBuild.Models;

namespace PKBuild.Data;

public class PKBuildDbContext : DbContext
{
    
    public DbSet<PokemonPageModel> Pokemon { get; set; }
    
    // TODO: User Table
    
    // TODO: Pokemon Teams Table(Junction Table)
    
    // TODO: Base Stats Table
    
    // TODO: Teams Table
    
    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=PKBuild.db");
    }
}