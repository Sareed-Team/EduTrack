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
    }
}
