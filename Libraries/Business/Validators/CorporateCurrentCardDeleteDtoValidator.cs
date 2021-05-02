using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validators
{
    public class CorporateCurrentCardDeleteDtoValidator : AbstractValidator<CorporateCurrentCardDeleteDto>
    {
        public CorporateCurrentCardDeleteDtoValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
        }
    }
}
