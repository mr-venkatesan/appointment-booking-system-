using AppointmentSystem.Application.Interfaces.Doctors;
using AppointmentSystem.Infrastructure.Persistence;
using AppointmentSystem.Infrastructure.Repositories.Doctors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppointmentSystem.Infrastructure.Configurations.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(
                configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IDoctorRepository, DoctorRepository>();

        return services;
    }
}
