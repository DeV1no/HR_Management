using FluentValidation;

namespace HR_Management.Application.DTOs.Leavetype.Validators;

public class CreateLeaveTypeDtoValidator : AbstractValidator<CreateLeaveTypeDto>
{
    public CreateLeaveTypeDtoValidator()
    {
        RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required")
            .NotEmpty()
            .NotNull()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed50");
        RuleFor(p => p.DefaultDay).NotEmpty().WithMessage("{PropertyName} is required")
            .GreaterThan(0).LessThan(100);
    }

}
