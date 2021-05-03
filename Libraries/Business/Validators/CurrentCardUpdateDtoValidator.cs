using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validators
{
    public class CurrentCardUpdateDtoValidator : AbstractValidator<CurrentCardUpdateDto>
    {
        public CurrentCardUpdateDtoValidator()
        {
            RuleFor(p => p.Id).NotEmpty();

            RuleFor(p => p.IsActive).NotEmpty();

            RuleFor(p => p.RegisteredDateTime).NotEmpty();
        }
    }
}
