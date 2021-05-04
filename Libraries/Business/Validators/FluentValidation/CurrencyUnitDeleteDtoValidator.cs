using Entities.Dtos;
using FluentValidation;

namespace Business.Validators
{
    public class CurrencyUnitDeleteDtoValidator : AbstractValidator<CurrencyUnitDeleteDto>
    {
        public CurrencyUnitDeleteDtoValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
        }
    }
}
