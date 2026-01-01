namespace AppointmentSystem.Application.DTOs.Doctor;

public class CreateDoctorDto
{
    public string Name { get; set; } = string.Empty;
    public string Specialization { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
}
