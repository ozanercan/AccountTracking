using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    /// <summary>
    /// Yabancı uyruklu cari eklemek için kullanılır
    /// </summary>
    public class ForeignIndividualCurrentCardAddDto : IDto
    {
        public Guid IndividualCurrentCardId { get; set; }
        public string PassportIdentityNumber { get; set; }
    }
}
