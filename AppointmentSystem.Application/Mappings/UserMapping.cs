using AppointmentSystem.Application.DTOs.Users;

using AppointmentSystem.Domain.Entities.Users;

namespace AppointmentSystem.Application.Mappings;

public static class UsersMapping
{
    public static UserResponseDto ToDto(this Users user)
    {
        return new UserResponseDto
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            PhoneNumber = user.PhoneNumber
        };
    }

    public static Users ToEntity(this CreateUserResponseDto dto)
    {
        return new Users(
            dto.Name,
            dto.Email,
            dto.PhoneNumber,
            dto.Password,
            "Admin"
        );
    }
}