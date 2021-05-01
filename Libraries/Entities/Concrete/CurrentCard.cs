using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   // bireysel ve kurumsal carilere inherit edilen class
    // telefon numarası, email, adres sınırsız tutulabileceğinden türleri liste
    public class CurrentCard : IEntity
    {
        public List<CurrentCardPhoneNumber> PhoneNumbers { get; set; }
        public List<CurrentCardEmail> Emails { get; set; }
        public List<CurrentCardAddress> Addresses { get; set; }
    }
}
