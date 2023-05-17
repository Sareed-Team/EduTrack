using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCentre.Service.DTOs.Users
{
    public class UserUpdateDto
    {
        [Required(ErrorMessage = "Group is required")]
        public string Group { get; set; }
        [Required(ErrorMessage = "Pay is required")]
        public string Pay { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Direction is required")]
        public string Direction { get; set; }
        [Required(ErrorMessage = "PhoneNumber is required")]
        public string PhoneNumber { get; set; }
    }
}
