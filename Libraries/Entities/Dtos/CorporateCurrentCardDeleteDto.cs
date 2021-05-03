using Core.Entities.Abstract;
using System;

namespace Entities.Dtos
{
    /// <summary>
    /// Kurumsal cari kart silmek için kullanılır.
    /// </summary>
    public class CorporateCurrentCardDeleteDto : IDto
    {
        public Guid Id { get; set; }
    }
}
