using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PKBuild.Models;

namespace PKBuild.Configurations;

public class PokemonConfig : IEntityTypeConfiguration<PokemonPageModel>
{
    public void Configure(EntityTypeBuilder<PokemonPageModel> builder)
    {
        builder.ToTable("Pokemon");
        builder.HasKey(pkmn => pkmn.PkmnId);
        builder.Property(pkmn => pkmn.PkdxRegNum).IsRequired();
        builder.Property(pkmn => pkmn.PkdxNatNum).IsRequired();
        builder.Property(pkmn => pkmn.EVHp).IsRequired();
        builder.Property(pkmn => pkmn.EVAtk).IsRequired();
        builder.Property(pkmn => pkmn.EVDef).IsRequired();
        builder.Property(pkmn => pkmn.EVSpA).IsRequired();
        builder.Property(pkmn => pkmn.EVSpD).IsRequired();
        builder.Property(pkmn => pkmn.EVSpe).IsRequired();
        builder.Property(pkmn => pkmn.IVHp).IsRequired();
        builder.Property(pkmn => pkmn.IVAtk).IsRequired();
        builder.Property(pkmn => pkmn.IVDef).IsRequired();
        builder.Property(pkmn => pkmn.IVSpA).IsRequired();
        builder.Property(pkmn => pkmn.IVSpD).IsRequired();
        builder.Property(pkmn => pkmn.IVSpe).IsRequired();
        builder.Property(pkmn => pkmn.Alpha).IsRequired();
        builder.Property(pkmn => pkmn.GMax).IsRequired();
        builder.Property(pkmn => pkmn.TeraBaseType).IsRequired();
        builder.Property(pkmn => pkmn.TeraOverrideType).IsRequired();
    }
}