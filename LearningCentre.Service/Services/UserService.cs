using AutoMapper;
using LearningCentre.DAL.IRepository;
using LearningCentre.Domain.Entities.Users;
using LearningCentre.Service.DTOs.Users;
using LearningCentre.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearningCentre.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper mapper;
        private readonly IRepository<User> userRepository;
        public ValueTask<UserResultDto> CreateAsync(UserCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IEnumerable<UserResultDto>> GetAllAsync(Expression<Func<User, bool>> expression = null, string search = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask<UserResultDto> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<UserResultDto> UpdateAsync(UserUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
