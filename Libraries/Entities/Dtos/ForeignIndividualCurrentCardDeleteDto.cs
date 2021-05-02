using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{/// <summary>
/// Yabancı uyruklu cari silmek için kullanılır
/// </summary>
    public class ForeignIndividualCurrentCardDeleteDto : IDto
    {
        public Guid Id { get; set; }
    }
}
