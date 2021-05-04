using Core.Entities.Abstract;
using System;

namespace Entities.Concrete
{
    /// <summary>
    /// CorporateCurrentCardId özelliği kurumlar arasındaki sıralama için id'dir. Örneğin 1. şirket, 2. şirket
    /// </summary>
    public class CorporateCurrentCard : IEntity
    {
        public Guid Id { get; set; }
        public Guid CurrentCardId { get; set; }
        public string Name { get; set; }
        public string TaxNumber { get; set; }
        public string TaxAdministration { get; set; }
        public string Description { get; set; }
    }
}
