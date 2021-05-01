using Core.Entities.Abstract;
using System;

namespace Entities.Concrete
{
    /// <summary>
    /// Taksit Durumu için kullanılır. (Ödenmedi, Ödendi, ...)
    /// </summary>
    public class InstallmentStatu : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
