using Entities.Dtos;
using FluentValidation;

namespace Business.Validators.FluentValidation
{
    public class CurrentCardAndLocalIndividualAddDtoValidator : AbstractValidator<CurrentCardAndLocalIndividualAddDto>
    {
        public CurrentCardAndLocalIndividualAddDtoValidator()
        {
            RuleFor(p => p.CurrentCardAddDto).NotNull();
            RuleFor(p => p.IndividualCurrentCardAddDto).NotNull();
            RuleFor(p => p.LocalIndividualCurrentCardAddDto).NotNull();
        }
    }
}
