using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validators.FluentValidation
{
    public class LocalIndividualCurrentCardUpdateDtoValidator : AbstractValidator<LocalIndividualCurrentCardUpdateDto>
    {
        public LocalIndividualCurrentCardUpdateDtoValidator()
        {
            RuleFor(p => p.Id).NotEmpty();

            RuleFor(p => p.IndividualCurrentCardId).NotEmpty();

            RuleFor(p => p.IdentityNumber).NotEmpty();
            RuleFor(p => p.IdentityNumber).MinimumLength(11);
            RuleFor(p => p.IdentityNumber).MaximumLength(11);
        }
    }
}
