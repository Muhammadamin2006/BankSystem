using BankSystem.Application.Dtos;
using BankSystem.Application.IRepository;
using FluentValidation;

namespace BankSystem.Application.FluentValidations;

public class RegistrationValidator : AbstractValidator<CreateClientDto>
{
    public RegistrationValidator(IClientRepository clientRepository)
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name cannot be empty").WithErrorCode("NameError")
            .MinimumLength(3).WithMessage("Minimum length of 3 characters").WithErrorCode("MinimumLength_Name_Error")
            .MaximumLength(20).WithMessage("Maximum length of 20 characters").WithErrorCode("MaximumLength_Name_Error")
            .Must(x => x.StartsWith(@"^[A-Z][a-z]+$")).WithMessage("Name must start with a capital letter and contain only lowercase letters after it").WithErrorCode("Invalid_Name_Error");
        
        RuleFor(x => x.PassportNumber)
            .MustAsync(async (passportNumber, _) => !await clientRepository.PassportNumberExistAsync(passportNumber)).WithMessage("Passport number does not exist").WithErrorCode("PassportNumber_DoesNotExist_Error")
            .NotEmpty().WithMessage("Passport number cannot be empty").WithErrorCode("PassportNumber_Empty_Error")
            .Length(7, 7).WithMessage("Passport number should be 7 characters").WithErrorCode("PassportNumber_Length_Error");
    }
    
}