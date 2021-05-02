using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class CorporateCurrentCardDeleteDto : IDto
    {
        public Guid Id { get; set; }
    }
}
