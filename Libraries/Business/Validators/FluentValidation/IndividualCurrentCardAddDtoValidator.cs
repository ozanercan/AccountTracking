using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validators.FluentValidation
{
    public class IndividualCurrentCardAddDtoValidator : AbstractValidator<IndividualCurrentCardAddDto>
    {
        public IndividualCurrentCardAddDtoValidator()
        {
            RuleFor(p => p.BirthDate).NotEmpty();

            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MinimumLength(2);
            RuleFor(p => p.FirstName).MaximumLength(50);

            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).MinimumLength(2);
            RuleFor(p => p.LastName).MaximumLength(50);
        }
    }
}
