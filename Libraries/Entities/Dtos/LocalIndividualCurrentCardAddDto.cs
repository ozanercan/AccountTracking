using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{/// <summary>
/// Yerli cari eklemek için kullanılır
/// </summary>
    public class LocalIndividualCurrentCardAddDto : IDto
    {
        public Guid IndividualCurrentCardId { get; set; }
        public string IdentityNumber { get; set; }
    }
}
