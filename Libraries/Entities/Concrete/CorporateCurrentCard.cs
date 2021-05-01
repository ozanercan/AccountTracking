using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   
    // CorporateCurrentCardId özelliği kurumlar arasındaki sıralama için id'dir. Örneğin 1. şirket, 2. şirket
    // Current Code = Cari kod
    public class CorporateCurrentCard : CurrentCard, IEntity
    {
        public int Id { get; set; }
        public int CorporateCurrentCardId { get; set; }
        public int CurrentCode { get; set; }
        public string TaxNumber { get; set; }
        public string CompanyName { get; set; }
        public string TaxAdministration { get; set; }
        public string Description { get; set; }
    }
}
