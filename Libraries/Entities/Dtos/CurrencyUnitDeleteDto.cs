using Core.Entities.Abstract;
using System;

namespace Entities.Dtos
{
    /// <summary>
    /// Para Birimi silmek için kullanılır.
    /// </summary>
    public class CurrencyUnitDeleteDto : IDto
    {
        public Guid Id { get; set; }
    }
}
