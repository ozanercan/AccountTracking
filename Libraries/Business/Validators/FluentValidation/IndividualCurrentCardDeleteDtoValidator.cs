using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validators.FluentValidation
{
    public class IndividualCurrentCardDeleteDtoValidator : AbstractValidator<IndividualCurrentCardDeleteDto>
    {
        public IndividualCurrentCardDeleteDtoValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
        }
    }
}
