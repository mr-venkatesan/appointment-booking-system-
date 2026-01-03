namespace AppointmentSystem.Application.DTOs.Users;
public class UserResponseDto
{
    public Guid Id { get; set; }
    public String Name { get; set;} = String.Empty;
    public String Email { get; set;} = String.Empty;
    public String PhoneNumber { get; set;} = String.Empty;

}