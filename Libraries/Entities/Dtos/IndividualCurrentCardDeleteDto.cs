using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{/// <summary>
/// Bireysel cari silmek için kullanılır
/// </summary>
    public class IndividualCurrentCardDeleteDto : IDto
    {
        public Guid Id { get; set; }
    }
}
