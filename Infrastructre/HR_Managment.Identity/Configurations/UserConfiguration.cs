using HR_Managment.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR_Managment.Identity.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        var hasher = new PasswordHasher<ApplicationUser>();
        builder.HasData(
             new ApplicationUser
             {
                 Id = "a425d5eb-d242-4728-965b-e65b3b5d7a11",
                 Email = "admin@localhost.com",
                 NormalizedEmail = "ADMIN@LOCALHOST.COM",
                 FirstName = "Admin",
                 LastName = "Adminian",
                 UserName = "admin@localhost.com",
                 NormalizedUserName = "ADMIN@LOCALHOST.COM",
                 PasswordHash = hasher.HashPassword(null, "p@ssword1"),
                 EmailConfirmed = true
             },
             new ApplicationUser
             {
                 Id = "983e9410-58bb-4ce9-91b2-88ae3ceeca8b",
                 Email = "user@localhost.com",
                 NormalizedEmail = "USER@LOCALHOST.COM",
                 FirstName = "System",
                 LastName = "user",
                 UserName = "user@localhost.com",
                 NormalizedUserName = "USER@LOCALHOST.COM",
                 PasswordHash = hasher.HashPassword(null, "p@ssword1"),
                 EmailConfirmed = true
             });
    }
}