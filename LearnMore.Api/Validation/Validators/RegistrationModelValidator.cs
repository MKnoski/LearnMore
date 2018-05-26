using FluentValidation;
using LearnMore.Domain.Constants;
using LearnMore.Domain.Models;

namespace LearnMore.Api.Validation.Validators
{
    public class RegistrationModelValidator : AbstractValidator<Registration>
    {
        public RegistrationModelValidator()
        {
            RuleFor(vm => vm.Email)
                .NotEmpty().WithMessage(ErrorMessages.EmailEmpty)
                .EmailAddress().WithMessage(ErrorMessages.EmailValid);

            RuleFor(vm => vm.Password)
                .NotEmpty().WithMessage(ErrorMessages.PasswordEmpty)
                .MinimumLength(UserConsts.PasswordMinLenght).WithMessage(ErrorMessages.PasswordMinLength)
                .Matches("[A-Z]").WithMessage(ErrorMessages.PasswordUppercaseLetter)
                .Matches("[a-z]").WithMessage(ErrorMessages.PasswordLowercaseLetter)
                .Matches("[0-9]").WithMessage(ErrorMessages.PasswordDigit)
                .Matches("[^a-zA-Z0-9]").WithMessage(ErrorMessages.PasswordSpecialCharacter);

            RuleFor(vm => vm.FirstName).NotEmpty().WithMessage(ErrorMessages.FirstNameEmpty);
            RuleFor(vm => vm.LastName).NotEmpty().WithMessage(ErrorMessages.LastNameEmpty);

        }
    }
}
