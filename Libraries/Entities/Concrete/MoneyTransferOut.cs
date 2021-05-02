using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    /// <summary>
    /// Ödenecek Borç için kullanılır.
    /// </summary>
    public class MoneyTransferOut : IEntity
    {
        public Guid Id { get; set; }
        public Guid CurrentId { get; set; }
        public Guid UserId { get; set; }
        public Guid CurrencyUnitId { get; set; }
        public string SecondaryIdentity { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime EstimatedPaymentDateTime { get; set; }
        public DateTime? PaymentDateTime { get; set; }
        public DateTime RegisterDateTime { get; set; }
    }
}
