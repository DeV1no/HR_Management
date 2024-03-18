using HR_Managment.Identity.Configurations;
using HR_Managment.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HR_Managment.Identity;

public class LeaveManagementIdentityDbContext : IdentityDbContext<ApplicationUser>
{
    public LeaveManagementIdentityDbContext(DbContextOptions<LeaveManagementIdentityDbContext> options)
         : base(options)
    {



    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new UserRoleConfiguration());

    }
}