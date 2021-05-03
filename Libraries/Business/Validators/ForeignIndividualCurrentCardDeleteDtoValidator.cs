using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validators
{
    public class ForeignIndividualCurrentCardDeleteDtoValidator : AbstractValidator<ForeignIndividualCurrentCardDeleteDto>
    {
        public ForeignIndividualCurrentCardDeleteDtoValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
        }
    }
}
