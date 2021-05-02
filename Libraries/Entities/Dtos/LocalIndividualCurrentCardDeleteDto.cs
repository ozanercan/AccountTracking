using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{/// <summary>
/// Yerli cari silmek için kullanılır
/// </summary>
    public class LocalIndividualCurrentCardDeleteDto : IDto
    {
        public Guid Id { get; set; }
    }
}
