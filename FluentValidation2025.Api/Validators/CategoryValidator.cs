using FluentValidation;
using FluentValidation2025.Api.Models;

namespace FluentValidation2025.Api.Validators;

public class CategoryValidator : AbstractValidator<Category>
{
    public CategoryValidator()
    {
        RuleFor(a => a.Id).NotNull().WithMessage("Id cannot be null");

        RuleFor(a => a.Name)
            .NotNull().WithMessage("Name is required")
            .NotEmpty().WithMessage("Name cannot be empty")
            .MaximumLength(50).WithMessage("Name cannot exceed 50 characters");

    }
}
