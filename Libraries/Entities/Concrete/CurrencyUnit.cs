using Core.Entities.Abstract;
using System;

namespace Entities.Concrete
{
    /// <summary>
    /// Para Birimi için kullanılır.
    /// </summary>
    public class CurrencyUnit : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
