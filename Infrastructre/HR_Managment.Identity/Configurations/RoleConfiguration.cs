using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR_Managment.Identity.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Id = "46fedc27-3fa9-4ae5-b45e-cffcd713a5dc",
                Name = "Employe",
                NormalizedName = "EMPLOYEE"
            },
            new IdentityRole
            {
                Id = "04b867a9-7588-431a-9d87-7ee674cf4741",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            }
        );
    }
}