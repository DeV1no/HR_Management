using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using HR_Managment.Identity.Models;
using HR_Management.Application.Contracts.Identity;
using HR_Managment.Identity.Services;
using Microsoft.EntityFrameworkCore;
using HR_Management.Application.Models.Identity;

namespace HR_Managment.Identity
{
    public static class IdentityServicesRegistration
    {
        public static IServiceCollection ConfigureIdentityServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            // Configure JWT settings
            var jwtSettings = configuration.GetSection("JwtSettings").Get<JwtSettings>();
            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

            // Configure DbContext for Identity
            services.AddDbContext<LeaveManagementIdentityDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("LeaveManagementIdentityConnectionString"),
                    b => b.MigrationsAssembly(typeof(LeaveManagementIdentityDbContext).Assembly.FullName)));

            // Configure Identity
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                // Password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = false;
            })
                .AddEntityFrameworkStores<LeaveManagementIdentityDbContext>()
                .AddDefaultTokenProviders();

            // Register AuthService
            services.AddTransient<IAuthService, AuthService>();

            // Configure JWT authentication
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtSettings.Key)),
                        ValidateIssuer = true,
                        ValidIssuer = jwtSettings.Issuer,
                        ValidateAudience = true,
                        ValidAudience = jwtSettings.Audience,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero // No clock skew
                    };
                });

            return services;
        }
    }
}
