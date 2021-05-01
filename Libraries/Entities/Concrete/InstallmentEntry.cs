using Core.Entities.Abstract;
using System;

namespace Entities.Concrete
{
    /// <summary>
    /// Alınacak Taksit için kullanılır.
    /// </summary>
    public class InstallmentEntry : IEntity
    {
        public Guid Id { get; set; }
        public Guid InstallmentStatuId { get; set; }
        public Guid MoneyTransferEntryId { get; set; }
        public int Which { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime EstimatedPaymentDateTime { get; set; }
        public DateTime? PaymentDateTime { get; set; }
        public DateTime RegisterDateTime { get; set; }
    }
}
