using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR_Managment.Identity.Configurations;

public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "46fedc27-3fa9-4ae5-b45e-cffcd713a5dc",
                UserId = "a425d5eb-d242-4728-965b-e65b3b5d7a11"
            },

            new IdentityUserRole<string>
            {
                RoleId = "04b867a9-7588-431a-9d87-7ee674cf4741",
                UserId = "983e9410-58bb-4ce9-91b2-88ae3ceeca8b"
            }
        );
    }
}