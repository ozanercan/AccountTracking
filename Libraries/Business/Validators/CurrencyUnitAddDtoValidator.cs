using Entities.Dtos;
using FluentValidation;

namespace Business.Validators
{
    public class CurrencyUnitAddDtoValidator : AbstractValidator<CurrencyUnitAddDto>
    {
        public CurrencyUnitAddDtoValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(2);
            RuleFor(p => p.Name).MaximumLength(50);

            RuleFor(p => p.ShortName).NotEmpty();
            RuleFor(p => p.ShortName).MinimumLength(2);
            RuleFor(p => p.ShortName).MaximumLength(50);

            RuleFor(p => p.Symbol).NotEmpty();
            RuleFor(p => p.Symbol).MinimumLength(1);
            RuleFor(p => p.Symbol).MaximumLength(50);

            RuleFor(p => p.IsActive).NotEmpty();
        }
    }
}
