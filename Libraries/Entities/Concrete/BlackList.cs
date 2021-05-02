using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   // Kara liste
    // Cariler, bireysel/kurumsal cari kart id'si ile kara listeye düşer
    public class BlackList : IEntity
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int CurrentCardId { get; set; }
        public string Description { get; set; }
        public DateTime RegisterDateTime { get; set; }
    }
}
