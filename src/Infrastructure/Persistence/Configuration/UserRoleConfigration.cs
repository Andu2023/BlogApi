using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

public class UserRoleConfigration : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
       builder.ToTable("UserRoles");
builder.HasKey(ur=>new { ur.UserId, ur.RoleId });
builder.HasOne(ur=>ur.User)
.WithMany(u =>u.UserRoles)
.HasForeignKey(ur=> ur.UserId);
builder.HasOne(ur =>ur. Role)
.WithMany(r=>r.UserRoles)
.HasForeignKey(ur =>ur. RoleId);  
    }
}
