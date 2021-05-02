using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{/// <summary>
/// Bireysel cari eklemek için kullanılır
/// </summary>
    public class IndividualCurrentCardAddDto : IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
