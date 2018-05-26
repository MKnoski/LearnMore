using LearnMore.Domain.Enums;

namespace LearnMore.Domain.Models
{
    public class Registration
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }
    }
}