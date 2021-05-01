using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   // CurrentCard'da liste olarak tutulan PhoneNumbers prop'unun nesnesi
    public class CurrentCardPhoneNumber : IEntity
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
    }
}
