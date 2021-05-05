using Entities.Dtos;
using FluentValidation;

namespace Business.Validators.FluentValidation
{
    public class CurrentCardAndCorporateAddDtoValidator : AbstractValidator<CurrentCardAndCorporateAddDto>
    {
        public CurrentCardAndCorporateAddDtoValidator()
        {
            RuleFor(p => p.CurrentCardAddDto).NotNull();
            RuleFor(p => p.CorporateCurrentCardAddDto).NotNull();
        }
    }
}
