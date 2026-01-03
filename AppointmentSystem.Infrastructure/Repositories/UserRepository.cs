using AppointmentSystem.Application.Interfaces.User;
using AppointmentSystem.Domain.Entities.Users;
using AppointmentSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;


namespace AppointmentSystem.Infrastructure.Repositories.User;

public class UserRepository : IUsersRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Users>> GetAllUsersAsync()
        => await _context.Users.ToListAsync();

    public async Task<Users?> GetByIdAsync(Guid id)
        => await _context.Users.FindAsync(id);

    public async Task<Users?> GetUserAsync(String email)
        => await _context.Users.FindAsync(email);    

    public async Task AddAsync(Users user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Users user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var User = await _context.Users.FindAsync(id);
        if (User != null)
        {
            _context.Users.Remove(User);
            await _context.SaveChangesAsync();
        }
    }
}
