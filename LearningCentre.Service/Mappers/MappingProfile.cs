using AutoMapper;
using LearningCentre.Domain.Entities.Users;
using LearningCentre.Service.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCentre.Service.Mappers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserCreationDto>().ReverseMap();
            CreateMap<User, UserResultDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();
        }
    }
}
