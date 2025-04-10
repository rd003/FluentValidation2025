using FluentValidation;
using FluentValidation2025.Api.Models;

namespace FluentValidation2025.Api.Validators;

public class PersonValidator : AbstractValidator<Person>
{
    public PersonValidator()
    {
        RuleFor(a => a.Id).NotNull().WithMessage("Id cannot be null");

        RuleFor(a => a.Name)
            .NotNull().WithMessage("Name is required")
            .NotEmpty().WithMessage("Name cannot be empty")
            .MaximumLength(50).WithMessage("Name cannot exceed 50 characters");

        RuleFor(a => a.Email)
            .NotNull().WithMessage("Email is required")
            .NotEmpty().WithMessage("Email cannot be empty")
            .MaximumLength(200).WithMessage("Email cannot exceed 200 characters")
            .EmailAddress().WithMessage("Please provide a valid email address");

        RuleFor(a => a.Age)
            .NotNull().WithMessage("Age is required");

        RuleFor(person => person.Password)
            .NotEmpty()
            .NotNull()
            .MaximumLength(20)
            .Matches("^(?=.*\\d).*$")
            .WithMessage("Password must contain numeric value");
    }
}
