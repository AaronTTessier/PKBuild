using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PKBuild.Models;

namespace PKBuild.Configurations;

public class ItemConfig : IEntityTypeConfiguration<ItemPageModel>
{
    public void Configure(EntityTypeBuilder<ItemPageModel> builder)
    {
        builder.ToTable("Items");
        builder.HasKey(usr => usr.ItemId);
    }
}