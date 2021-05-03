using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validators
{
    public class CurrentCardDeleteDtoValidator : AbstractValidator<CurrentCardDeleteDto>
    {
        public CurrentCardDeleteDtoValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
        }
    }
}
