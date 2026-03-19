using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PKBuild.Models;

namespace PKBuild.Configurations;

public class BaseStatesConfig : IEntityTypeConfiguration<BaseStatsPageModel>
{
    public void Configure(EntityTypeBuilder<BaseStatsPageModel> builder)
    {
        builder.ToTable("Base Stats");
        builder.HasKey(bs => bs.StatId);
        builder.Property(bs => bs.NatNum).IsRequired();
        builder.Property(bs => bs.StatTotal).IsRequired();
        builder.Property(bs => bs.StatHp).IsRequired();
        builder.Property(bs => bs.StatAtk).IsRequired();
        builder.Property(bs => bs.StatDef).IsRequired();
        builder.Property(bs => bs.StatSpA).IsRequired();
        builder.Property(bs => bs.StatSpD).IsRequired();
        builder.Property(bs => bs.StatSpe).IsRequired();
    }
}