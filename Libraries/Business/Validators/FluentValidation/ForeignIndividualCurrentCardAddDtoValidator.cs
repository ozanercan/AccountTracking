using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validators.FluentValidation
{
    public class ForeignIndividualCurrentCardAddDtoValidator : AbstractValidator<ForeignIndividualCurrentCardAddDto>
    {
        public ForeignIndividualCurrentCardAddDtoValidator()
        {
            RuleFor(p => p.IndividualCurrentCardId).NotEmpty();

            RuleFor(p => p.PassportIdentityNumber).NotEmpty();
            RuleFor(p => p.PassportIdentityNumber).MinimumLength(2);
            RuleFor(p => p.PassportIdentityNumber).MaximumLength(50);

        }
    }
}
