using Entities.Dtos;
using FluentValidation;

namespace Business.Validators
{
    public class CurrentCardAndCorporateAddDtoValidator : AbstractValidator<CurrentCardAndCorporateAddDto>
    {
        public CurrentCardAndCorporateAddDtoValidator()
        {
            RuleFor(p => p.CorporateCurrentCardAddDto).NotNull();
            RuleFor(p => p.CurrentCardAddDto).NotNull();
        }
    }
}
