using HR_Management.Application.Contracts.Infrastructure;
using HR_Management.Application.Models;
using HR_Management.Infrastructre.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HR_Management.Infrastructre;

public static class InfrastractureServiceRegistration
{
    public static IServiceCollection ConfigureInfrastractureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<EmailSetting>(configuration.GetSection("EmailSettings"));
        services.AddTransient<IEmailSender, EmailSender>();
        return services;
    }
}
