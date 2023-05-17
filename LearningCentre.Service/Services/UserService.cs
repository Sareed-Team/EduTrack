using AutoMapper;
using LearningCentre.DAL.IRepository;
using LearningCentre.Domain.Entities.Users;
using LearningCentre.Service.DTOs.Users;
using LearningCentre.Service.Exceptions;
using LearningCentre.Service.Interfaces;
using System.Linq.Expressions;


namespace LearningCentre.Service.Services;

public class UserService : IUserService
{
    private readonly IMapper mapper;
    private readonly IRepository<User> userRepository;

    public UserService(IMapper mapper, IRepository<User> Repository)
    {
        this.mapper = mapper;
        this.userRepository = Repository;
    }

    public async ValueTask<UserResultDto> CreateAsync(UserCreationDto dto)
    {
        User user = await this.userRepository.SelectAsync(u => u.FirstName.ToLower() == dto.FirstName.ToLower());
        if (user is not null)
            throw new LearningCentreException(403, "User already exist with this username");

        User mappedUser = mapper.Map<User>(dto);
        var result = await this.userRepository.InsertAsync(mappedUser);
        await this.userRepository.SaveChangesAsync();
        return this.mapper.Map<UserResultDto>(result);
    }

    public async ValueTask<bool> DeleteAsync(long id)
    {
        var user = await this.userRepository.SelectAsync(u => u.Id.Equals(id));
        if (user is null)
            throw new LearningCentreException(404, "User not found");

        await this.userRepository.DeleteAsync(user.Id);
        await this.userRepository.SaveChangesAsync();
        return true;
    }

    public async ValueTask<IEnumerable<UserResultDto>> GetAllAsync(Expression<Func<User, bool>> expression = null, string search = null)
    {
        var users = userRepository.SelectAll(expression, isTracking: false);
        var result = mapper.Map<IEnumerable<UserResultDto>>(users);

        if (!string.IsNullOrEmpty(search))
        {
            var lowercaseSearch = search.ToLower();

            return result.Where(u =>
                u.FirstName.IndexOf(lowercaseSearch, StringComparison.OrdinalIgnoreCase) >= 0 ||
                u.LastName.IndexOf(lowercaseSearch, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }
        
        return result;
    }


    public async ValueTask<UserResultDto> GetByIdAsync(long id)
    {
        var user = await userRepository.SelectAsync(u => u.Id.Equals(id));
        if (user is null)
            throw new LearningCentreException(404, "User not found");

        return mapper.Map<UserResultDto>(user);
    }

    public async ValueTask<UserResultDto> UpdateAsync(UserUpdateDto dto)
    {
        var updatingUser = await userRepository.SelectAsync(u => u.Id.Equals(dto.Id));
        if (updatingUser is null)
            throw new LearningCentreException(404, "Foydalanuvchi topilmadi");

        mapper.Map(dto, updatingUser);
        updatingUser.UpdatedAt = DateTime.UtcNow;
        await userRepository.SaveChangesAsync();

        return mapper.Map<UserResultDto>(updatingUser);
    }


}
