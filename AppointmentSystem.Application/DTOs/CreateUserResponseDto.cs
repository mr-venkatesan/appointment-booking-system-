namespace AppointmentSystem.Application.DTOs.Users;

public class CreateUserResponseDto
{
    public String Name { get; set;} = String.Empty;
    public String Email { get; set;} = String.Empty;
    public String PhoneNumber { get; set;} = String.Empty;
    public String Password { get; set;} = String.Empty;

}