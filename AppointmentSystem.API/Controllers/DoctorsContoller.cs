using AppointmentSystem.Application.DTOs.Doctor;
using AppointmentSystem.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentSystem.API.Controllers;

[ApiController]
[Route("api/doctors")]
public class DoctorsController : ControllerBase
{
    private readonly DoctorService _service;

    public DoctorsController(DoctorService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _service.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var doctor = await _service.GetByIdAsync(id);
        return doctor == null ? NotFound() : Ok(doctor);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateDoctorDto dto)
    {
        await _service.CreateAsync(dto);
        return Ok("Doctor created successfully");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, CreateDoctorDto dto)
    {
        await _service.UpdateAsync(id, dto);
        return Ok("Doctor updated successfully");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _service.DeleteAsync(id);
        return Ok("Doctor deleted successfully");
    }
}

