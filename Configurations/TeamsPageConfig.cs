using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PKBuild.Models;

namespace PKBuild.Configurations;

public class TeamsPageConfig : IEntityTypeConfiguration<TeamsPageModel>
{
    public void Configure(EntityTypeBuilder<TeamsPageModel> builder)
    {
        builder.ToTable("Teams");
        builder.HasKey(t => t.TeamId);
        builder.Property(t => t.UserId).IsRequired();
        builder.Property(t => t.TeamName).HasMaxLength(20).IsRequired();
        builder.Property(t => t.Favorite).IsRequired();
    }
}