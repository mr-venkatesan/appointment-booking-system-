using AppointmentSystem.Application.DTOs.Doctor;
using AppointmentSystem.Application.Interfaces;
using AppointmentSystem.Domain.Entities;
using AppointmentSystem.Application.Mappings;

namespace AppointmentSystem.Application.Services;

public class DoctorService
{
    private readonly IDoctorRepository _repository;

    public DoctorService(IDoctorRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<DoctorResponseDto>> GetAllAsync()
    {
        var doctors = await _repository.GetAllAsync();
        return doctors.Select(d => d.ToDto());
    }

    public async Task<DoctorResponseDto?> GetByIdAsync(Guid id)
    {
        var doctor = await _repository.GetByIdAsync(id);
        if (doctor == null) return null;
        return doctor.ToDto();
    }

    public async Task CreateAsync(CreateDoctorDto dto)
    {
        var doctor = dto.ToEntity();    
        await _repository.AddAsync(doctor);
    }

    public async Task UpdateAsync(Guid id, CreateDoctorDto dto)
    {
        var doctor = await _repository.GetByIdAsync(id);
        if (doctor == null)
            throw new Exception("Doctor not found");

        doctor.Update(dto.Name, dto.Specialization, dto.PhoneNumber,id.ToString());
        await _repository.UpdateAsync(doctor);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
    }
}
