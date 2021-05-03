using Core.Entities.Abstract;
using System;

namespace Entities.Dtos
{
    /// <summary>
    /// Kurumsal cari kart güncellemek için kullanılır.
    /// </summary>
    public class CorporateCurrentCardUpdateDto : IDto
    {
        public Guid Id { get; set; }
        public Guid CurrentCardId { get; set; }
        public string CurrentCode { get; set; }
        public string TaxNumber { get; set; }
        public string CompanyName { get; set; }
        public string TaxAdministration { get; set; }
        public string Description { get; set; }
    }
}
