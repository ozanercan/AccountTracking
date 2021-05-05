using Core.Entities.Abstract;

namespace Entities.Dtos
{
    public class CurrentCardAndLocalIndividualAddDto : IDto
    {
        public CurrentCardAddDto CurrentCardAddDto { get; set; }
        public IndividualCurrentCardAddDto IndividualCurrentCardAddDto { get; set; }
        public LocalIndividualCurrentCardAddDto LocalIndividualCurrentCardAddDto { get; set; }
    }
}
