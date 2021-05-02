using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    /// <summary>
    /// CorporateCurrentCardId özelliği kurumlar arasındaki sıralama için id'dir. Örneğin 1. şirket, 2. şirket
    /// </summary>
    public class CorporateCurrentCard : IEntity
    {
        public Guid Id { get; set; }
        public Guid CorporateCurrentCardId { get; set; }
        public string CurrentCode { get; set; }
        public string TaxNumber { get; set; }
        public string CompanyName { get; set; }
        public string TaxAdministration { get; set; }
        public string Description { get; set; }
    }
}
