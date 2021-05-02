using Core.Entities.Abstract;
using System;

namespace Entities.Concrete
{
    /// <summary>
    /// Alınacak Borç için kullanılır.
    /// </summary>
    public class MoneyTransferEntry : IEntity
    {
        public Guid Id { get; set; }
        public Guid CurrentId { get; set; }
        public Guid UserId { get; set; }
        public Guid PaymentStatuId { get; set; }
        public Guid CurrencyUnitId { get; set; }
        public string SecondaryIdentity { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime EstimatedReceivingMoneyDateTime { get; set; }
        public DateTime? ReceivingMoneyDateTime { get; set; }
        public DateTime RegisterDateTime { get; set; }
    }
}
