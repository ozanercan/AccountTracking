using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class CurrentCardAddDto : IDto
    {
        public DateTime RegisteredDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
