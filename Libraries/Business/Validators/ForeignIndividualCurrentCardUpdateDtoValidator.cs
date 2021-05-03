using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validators
{
    public class ForeignIndividualCurrentCardUpdateDtoValidator : AbstractValidator<ForeignIndividualCurrentCardUpdateDto>
    {
        public ForeignIndividualCurrentCardUpdateDtoValidator()
        {
            RuleFor(p => p.Id).NotEmpty();

            RuleFor(p => p.IndividualCurrentCardId).NotEmpty();

            RuleFor(p => p.IdentityNumber).NotEmpty();
            RuleFor(p => p.IdentityNumber).MinimumLength(2);
            RuleFor(p => p.IdentityNumber).MaximumLength(50);
        }
    }
}
