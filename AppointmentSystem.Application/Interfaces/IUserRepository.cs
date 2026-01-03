using AppointmentSystem.Domain.Entities.Users;

namespace AppointmentSystem.Application.Interfaces.User;
public interface IUsersRepository
{
    Task<IEnumerable<Users>> GetAllUsersAsync();
    Task<Users?> GetByIdAsync(Guid id);
    Task<Users?> GetUserAsync(String email);
    Task AddAsync(Users user);
    Task UpdateAsync(Users user);
    Task DeleteAsync(Guid id);

}