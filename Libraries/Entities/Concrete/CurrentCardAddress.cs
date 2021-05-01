using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   // CurrentCard'da liste olarak tutulan Addresses prop'unun nesnesi
    public class CurrentCardAddress : IEntity
    {
        public int Id { get; set; }
        public string Address { get; set; }
    }
}
