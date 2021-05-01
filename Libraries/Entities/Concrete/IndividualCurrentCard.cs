using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   
    // IndividualCurrentCardId özelliği bireyseller arasındaki sıralama için id'dir. Örneğin 1. şahıs, 2. şahıs
    public class IndividualCurrentCard : CurrentCard, IEntity
    {
        public int Id { get; set; }
        public int IndividualCurrentCardId { get; set; }
        public int IdentificationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public int DateOfBirth { get; set; }
    }
}
