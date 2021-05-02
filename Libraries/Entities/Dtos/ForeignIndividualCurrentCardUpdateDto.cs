using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{/// <summary>
/// Yabancı uyruklu cariyi güncellemek için kullanılır
/// </summary>
    public class ForeignIndividualCurrentCardUpdateDto : IDto
    {
        public Guid Id { get; set; }
        public Guid IndividualCurrentCardId { get; set; }
        public string IdentityNumber { get; set; }
    }
}
