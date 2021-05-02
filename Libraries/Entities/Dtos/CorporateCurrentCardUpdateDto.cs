using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class CorporateCurrentCardUpdateDto : IDto
    {
        public Guid Id { get; set; }
        public Guid CorporateCurrentCardId { get; set; }
        public string CurrentCode { get; set; }
        public string TaxNumber { get; set; }
        public string CompanyName { get; set; }
        public string TaxAdministration { get; set; }
        public string Description { get; set; }
    }
}
