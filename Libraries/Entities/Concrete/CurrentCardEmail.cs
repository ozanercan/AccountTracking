using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   // CurrentCard'da liste olarak tutulan Emails prop'unun nesnesi
    public class CurrentCardEmail : IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
