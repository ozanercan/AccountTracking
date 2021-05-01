using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{/// <summary>
/// Ybancı uyruklu cari kart.
/// </summary>
    public class ForeignIndividualCurrentCart : IEntity
    {
        public Guid Id { get; set; }
        public int ForeignIdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
    }
}
