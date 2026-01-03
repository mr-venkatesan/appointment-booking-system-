using AppointmentSystem.Application.Interfaces.User;
using AppointmentSystem.Application.Mappings;
using AppointmentSystem.Application.DTOs.Users;

public class UserService
{
    private readonly IUsersRepository _repository;
    public UserService(IUsersRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<UserResponseDto>> GetAllUsersAsync()
    {
        var users = await _repository.GetAllUsersAsync();
        return users.Select(user=>user.ToDto());
    }

    public async Task<UserResponseDto?> GetByIdAsync(Guid id)
    {
        var user = await _repository.GetByIdAsync(id);
        if (user == null) return null;
        return user.ToDto();
    }
    public async Task<UserResponseDto?> GetByIdAsync(String email)
    {
        var user = await _repository.GetUserAsync(email);
        if (user == null) return null;
        return user.ToDto();
    }
        public async Task CreateAsync(CreateUserResponseDto dto)
    {
        var user = dto.ToEntity();    
        await _repository.AddAsync(user);
    }

    public async Task UpdateAsync(Guid id, CreateUserResponseDto dto)
    {
        var user = await _repository.GetByIdAsync(id);
        if (user == null)
            throw new Exception("User not found");

        user.Update(dto.Name, dto.Email, dto.PhoneNumber,dto.Password,id.ToString());
        await _repository.UpdateAsync(user);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
    }
}