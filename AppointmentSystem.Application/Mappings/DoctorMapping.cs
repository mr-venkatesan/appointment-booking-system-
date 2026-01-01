using AppointmentSystem.Application.DTOs.Doctor;
using AppointmentSystem.Domain.Entities;

namespace AppointmentSystem.Application.Mappings;

public static class DoctorMapping
{
    public static DoctorResponseDto ToDto(this Doctor doctor)
    {
        return new DoctorResponseDto
        {
            Id = doctor.Id,
            Name = doctor.Name,
            Specialization = doctor.Specialization,
            PhoneNumber = doctor.PhoneNumber
        };
    }

    public static Doctor ToEntity(this CreateDoctorDto dto)
    {
        return new Doctor(
            dto.Name,
            dto.Specialization,
            dto.PhoneNumber,
            "Admin"
        );
    }
}
