using LearningCentre.Domain.Entities.Users;
using LearningCentre.Service.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearningCentre.Service.Interfaces
{
    public interface IUserService
    {
        ValueTask<UserResultDto> CreateAsync(UserCreationDto dto);
        ValueTask<UserResultDto> UpdateAsync(UserUpdateDto dto);
        ValueTask<bool> DeleteAsync(long id);
        ValueTask<UserResultDto> GetByIdAsync(long id);
        ValueTask<IEnumerable<UserResultDto>> GetAllAsync(
        Expression<Func<Student, bool>> expression = null, string search = null);
    }
}
