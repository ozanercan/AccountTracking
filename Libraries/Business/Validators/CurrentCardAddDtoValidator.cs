using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validators
{
    public class CurrentCardAddDtoValidator : AbstractValidator<CurrentCardAddDto>
    {
        public CurrentCardAddDtoValidator()
        {
            RuleFor(p => p.IsActive).NotEmpty();

            RuleFor(p => p.RegisteredDateTime).NotEmpty();
        }
    }
}
