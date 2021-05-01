﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{/// <summary>
/// Yerel cari kart
/// </summary>
    public class LocalIndividualCurrentCart : IEntity
    {
        public Guid Id { get; set; }
        public int IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
    }
}
