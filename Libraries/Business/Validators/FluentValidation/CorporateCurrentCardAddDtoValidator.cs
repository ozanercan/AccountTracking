using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validators.FluentValidation
{
    public class CorporateCurrentCardAddDtoValidator : AbstractValidator<CorporateCurrentCardAddDto>
    {
        public CorporateCurrentCardAddDtoValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(2);
            RuleFor(p => p.Name).MaximumLength(50);

            RuleFor(p => p.CurrentCardId).NotEmpty();

            RuleFor(p => p.TaxNumber).NotEmpty();
            RuleFor(p => p.TaxNumber).MinimumLength(10);
            RuleFor(p => p.TaxNumber).MaximumLength(10);

            RuleFor(p => p.TaxAdministration).NotEmpty();
            RuleFor(p => p.TaxAdministration).MinimumLength(10);
            RuleFor(p => p.TaxAdministration).MaximumLength(50);

            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Description).MinimumLength(2);
            RuleFor(p => p.Description).MaximumLength(50);
        }
    }
}
