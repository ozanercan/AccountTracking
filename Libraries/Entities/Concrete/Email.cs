using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   /// <summary>
    /// Value değeri e-mail'i verir.
    /// </summary>
    public class Email : IEntity
    {
        public Guid Id { get; set; }
        public Guid CurrentCardId { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
    }
}
