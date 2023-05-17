using LearningCentre.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCentre.Service.DTOs.Users
{
    public class UserResultDto
    {
        public long Id { get; set; }
        public string Group { get; set; }
        public string Pay { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Direction { get; set; }
        public string PhoneNumber { get; set; }
        public UserRole Role { get; set; }
    }
}
