using System;
using LearnMore.Domain.Models;

namespace LearnMore.Domain.Constants
{
    public class ErrorMessages
    {
        public const string EmailEmpty = "Email cannot be empty";
        public const string PasswordDigit = "Password must contain digits";
        public const string PasswordSpecialCharacter = "Password must contain special characters";
        public const string PasswordEmpty = "Password cannot be empty";
        public const string PasswordUppercaseLetter = "Password must contain uppercase letter";
        public const string PasswordLowercaseLetter = "Password must contain lowercase letter";
        public const string EmailValid = "Email must be valid email address";
        public static string PasswordMinLength = $"Password minimum length is {UserConsts.PasswordMinLenght}";
        public static string FirstNameEmpty = "First name cannot be empty";
        public static string LastNameEmpty = "Last name cannot be empty";
    }
}
