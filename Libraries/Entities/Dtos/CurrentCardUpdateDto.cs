using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class CurrentCardUpdateDto : IDto
    {
        public Guid Id { get; set; }
        public DateTime RegisteredDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
