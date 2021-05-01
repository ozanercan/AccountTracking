using Core.Entities.Abstract;
using System;

namespace Entities.Concrete
{
    /// <summary>
    /// Ödeme Durumu için kullanılır. (Alınacak, Alındı, ...)
    /// </summary>
    public class PaymentStatu : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
