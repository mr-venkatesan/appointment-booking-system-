using AppointmentSystem.Domain.Entities.Doctor;

namespace AppointmentSystem.Application.Interfaces.Doctors;

public interface IDoctorRepository
{
    Task<IEnumerable<Doctor>> GetAllAsync();
    Task<Doctor?> GetByIdAsync(Guid id);
    Task AddAsync(Doctor doctor);
    Task UpdateAsync(Doctor doctor);
    Task DeleteAsync(Guid id);
}
