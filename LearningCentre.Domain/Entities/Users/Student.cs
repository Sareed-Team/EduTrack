using LearningCentre.Domain.Commons;

namespace LearningCentre.Domain.Entities.Users
{
    public class User : Auditable
    {
        public string Group { get; set; }
        public string Pay { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Direction { get; set; }
        public string PhoneNumber { get; set; }
    }
}
