﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    /// <summary>
    /// Cariler, bireysel/kurumsal cari kart id'si ile kara listeye düşer
    /// </summary>
    public class BlackList : IEntity
    {
        public Guid Id { get; set; }
        public Guid CurrentCardId { get; set; }
    }
}
