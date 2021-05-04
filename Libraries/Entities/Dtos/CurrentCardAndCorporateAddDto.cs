using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class CurrentCardAndCorporateAddDto : IDto
    {
        public CurrentCardAddDto CurrentCardAddDto { get; set; }
        public CorporateCurrentCardAddDto CorporateCurrentCardAddDto { get; set; }
    }
}
