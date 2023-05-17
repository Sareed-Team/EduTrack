using LearningCentre.Service.DTOs.Users;
using LearningCentre.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LearningCentre.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseController
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpPost]
        public async Task<IActionResult> PostStudents(UserCreationDto dto)
            => Ok(new
            {
                Code = 200,
                Error = "Succes",
                Data = await this.userService.CreateAsync(dto)
            });
        [HttpGet("by-id")]
        public async Task<IActionResult> GetAsync(long id)
            => Ok(new
            {
                Code = 200,
                Error = "Success",
                Data = await this.userService.GetByIdAsync(id)
            });
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllAsync()
            => Ok(new
            {
                Code = 200,
                Error = "Success",
                Data = await this.userService.GetAllAsync()
            });
        [HttpPut]
        public async Task<IActionResult> PutAsync(UserUpdateDto dto)
            => Ok(new
            {
                Code = 200,
                Error = "Success",
                Data = await this.userService.UpdateAsync(dto)
            });
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(long id)
            => Ok(new
            {
                Code = 200,
                Error = "Success",
                Data = await this.userService.DeleteAsync(id)
            });
    }
}
