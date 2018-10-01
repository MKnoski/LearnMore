using FluentValidation;
using LearnMore.Domain.Constants;
using LearnMore.Domain.Models;
using LearnMore.Domain.Models.Registration;
using LearnMore.Domain.Resources;

namespace LearnMore.Api.Validation.Validators
{
    public class RegistrationModelValidator : AbstractValidator<Registration>
    {
        public RegistrationModelValidator()
        {
            RuleFor(vm => vm.Email)
                .NotEmpty().WithMessage(ErrorResources.EmailEmpty)
                .EmailAddress().WithMessage(ErrorResources.EmailValid);

            RuleFor(vm => vm.Password)
                .NotEmpty().WithMessage(ErrorResources.PasswordEmpty)
                .MinimumLength(UserConstants.PasswordMinLength).WithMessage($"{ ErrorResources.PasswordMinLength } { UserConstants.PasswordMinLength }")
                .Matches(RegexConstants.UppercaseLettersOnly).WithMessage(ErrorResources.PasswordUppercaseLetter)
                .Matches(RegexConstants.LowercaseLettersOnly).WithMessage(ErrorResources.PasswordLowercaseLetter)
                .Matches(RegexConstants.DigitsOnly).WithMessage(ErrorResources.PasswordDigit)
                .Matches(RegexConstants.NoSpecialCharacter).WithMessage(ErrorResources.PasswordSpecialCharacter);

            RuleFor(vm => vm.FirstName).NotEmpty().WithMessage(ErrorResources.FirstNameEmpty);
            RuleFor(vm => vm.LastName).NotEmpty().WithMessage(ErrorResources.LastNameEmpty);

        }
    }
}
