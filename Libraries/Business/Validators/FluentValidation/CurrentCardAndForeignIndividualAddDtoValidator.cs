using Entities.Dtos;
using FluentValidation;

namespace Business.Validators.FluentValidation
{
    public class CurrentCardAndForeignIndividualAddDtoValidator : AbstractValidator<CurrentCardAndForeignIndividualAddDto>
    {
        public CurrentCardAndForeignIndividualAddDtoValidator()
        {
            RuleFor(p => p.CurrentCardAddDto).NotNull();
            RuleFor(p => p.IndividualCurrentCardAddDto).NotNull();
            RuleFor(p => p.ForeignIndividualCurrentCardAddDto).NotNull();
        }
    }
}
