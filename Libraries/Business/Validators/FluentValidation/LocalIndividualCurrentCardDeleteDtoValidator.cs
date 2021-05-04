using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validators.FluentValidation
{
    public class LocalIndividualCurrentCardDeleteDtoValidator : AbstractValidator<LocalIndividualCurrentCardDeleteDto>
    {
        public LocalIndividualCurrentCardDeleteDtoValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
        }
    }
}
