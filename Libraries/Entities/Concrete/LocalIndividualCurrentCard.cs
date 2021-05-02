using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    /// <summary>
    /// Yerel Cari Kart
    /// </summary>
    public class LocalIndividualCurrentCard : IEntity
    {
        public Guid Id { get; set; }
        public int IdentityNumber { get; set; }
    }
}
