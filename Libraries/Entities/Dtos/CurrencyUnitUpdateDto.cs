using Core.Entities.Abstract;
using System;

namespace Entities.Dtos
{
    /// <summary>
    /// Para Birimi güncellemek için kullanılır.
    /// </summary>
    public class CurrencyUnitUpdateDto : IDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Symbol { get; set; }
        public bool IsActive { get; set; }
    }
}
