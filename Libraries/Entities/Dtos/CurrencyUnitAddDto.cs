using Core.Entities.Abstract;

namespace Entities.Dtos
{
    /// <summary>
    /// Para Birimi eklemek için kullanılır.
    /// </summary>
    public class CurrencyUnitAddDto : IDto
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Symbol { get; set; }
        public bool IsActive { get; set; }
    }
}
