using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{/// <summary>
/// Bireysel cari güncellemek için kullanılır
/// </summary>
    public class IndividualCurrentCardUpdateDto : IDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
