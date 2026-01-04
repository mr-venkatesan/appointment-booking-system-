using AppointmentSystem.Application.DTOs.Users;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentSystem.API.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserService _service;

        public UsersController(UserService userService)
        {
            _service = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
    => Ok(await _service.GetAllUsersAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var User = await _service.GetByIdAsync(id);
            return User == null ? NotFound() : Ok(User);
        }

        [HttpGet("{email}")]
        public async Task<IActionResult> Get(String email)
        {
            var User = await _service.GetUserAsync(email);
            return User == null ? NotFound() : Ok(User);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserResponseDto dto)
        {
            await _service.CreateAsync(dto);
            return Ok("User created successfully");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, CreateUserResponseDto dto)
        {
            await _service.UpdateAsync(id, dto);
            return Ok("User updated successfully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteAsync(id);
            return Ok("User deleted successfully");
        }
    }
}
