using AppointmentSystem.Domain.Entities.Doctor;
using AppointmentSystem.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace AppointmentSystem.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Doctor> Doctors => Set<Doctor>();
    public DbSet<Users> Users => Set<Users>(); 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
