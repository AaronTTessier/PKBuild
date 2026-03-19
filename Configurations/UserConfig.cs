using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PKBuild.Models;

namespace PKBuild.Configurations;

public class UserConfig : IEntityTypeConfiguration<UserPageModel>
{
    public void Configure(EntityTypeBuilder<UserPageModel> builder)
    {
        builder.ToTable("Users");
        builder.HasKey(usr => usr.UserId);
        builder.Property(usr => usr.FirstName).HasMaxLength(50);
        builder.Property(usr => usr.Email).HasMaxLength(75);
        builder.Property(usr => usr.UserName).HasMaxLength(25).IsRequired();
        builder.Property(usr => usr.PasswordHash).HasMaxLength(50).IsRequired();
    }
}