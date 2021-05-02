﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{/// <summary>
/// Kurumsal cari kart eklemek için kullanılır.
/// </summary>
    public class CorporateCurrentCardAddDto : IDto
    {
        public Guid CorporateCurrentCardId { get; set; }
        public string CurrentCode { get; set; }
        public string TaxNumber { get; set; }
        public string CompanyName { get; set; }
        public string TaxAdministration { get; set; }
        public string Description { get; set; }
    }
}
