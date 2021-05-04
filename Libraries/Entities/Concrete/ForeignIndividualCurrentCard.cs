using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    /// <summary>
    /// Yabancı Uyruklu Cari Kart
    /// </summary>
    public class ForeignIndividualCurrentCard : IEntity
    {
        public Guid Id { get; set; }
        public Guid IndividualCurrentCardId { get; set; }
        public Guid NationalityId { get; set; }
        public string PassportIdentityNumber { get; set; }
    }
}
